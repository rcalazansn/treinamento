import { Component, OnInit, ViewChildren, ElementRef, AfterViewInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControlName } from '@angular/forms';
import { Produto } from '../models/produto';
import { ActivatedRoute, Router } from '@angular/router';
import { ProdutoService } from '../services/produto.service';
import { GenericValidator, ValidationMessages, DisplayMessage } from 'src/app/comum/generic-validator';
import { FornecedorService } from '../../fornecedores/services/fornecedor.service';
import { Fornecedor } from '../../fornecedores/models/fornecedor';
import { HttpErrorResponse } from '@angular/common/http';
import { Observable, fromEvent, merge } from 'rxjs';

@Component({
  selector: 'app-produtos-formulario',
  templateUrl: './produtos-formulario.component.html'
})
export class ProdutosFormularioComponent implements OnInit, AfterViewInit {

  errors: any[] = [];
  titulo = 'Novo produto';

  clickSalvar: boolean;

  imagemBase64: any;
  fileToUpload: File = null;

  formulario: FormGroup;
  produto: Produto;
  fornecedores: Fornecedor[];

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];
  genericValidator: GenericValidator;
  validationMessages: ValidationMessages;
  displayMessage: DisplayMessage = {};

  constructor(
    private fb: FormBuilder,
    private router: Router,
    private route: ActivatedRoute,
    private service: ProdutoService,
    private serviceFornecedor: FornecedorService

  ) { this.AddValidationMessages(); }


  ngOnInit() {
    this.obterFornecedores();

    this.createForm();

    const id = this.route.snapshot.paramMap.get('id');

    if (id) {
      this.titulo = 'Editar Produto';

      this.service.obter(id)
        .subscribe(result => {
          this.produto = result;
          this.formulario.patchValue(this.produto);
        });
    }
  }

  ngAfterViewInit(): void {
    const controlBlurs: Observable<any>[] = this.formInputElements
      .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(() => {
      this.displayMessage = this.genericValidator.processarMensagens(this.formulario);
    });
  }

  createForm() {
    this.formulario = this.fb.group({
      id: [''],
      fornecedorId: ['', [Validators.required]],
      nome: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(200)]],
      valor: ['', [Validators.required]],
      descricao: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(500)]],
      ativo: [false]
    });
  }

  AddValidationMessages() {
    this.validationMessages = {
      nome: {
        required: 'O Nome é requerido',
        minlength: 'Mínimo 2 caracteres',
        maxlenght: 'Máximo 200 caractes'
      },
      descricao: {
        required: 'Descrição é requerido',
        minlength: 'Mínimo 2 caracteres',
        maxlength: 'Máximo 500 caracteres'
      },
      valor: {
        required: 'Valor é requerido',
      },
      fornecedorId: {
        required: 'Fornecedor é requerido',
      },
    };

    this.genericValidator = new GenericValidator(this.validationMessages);
  }

  obterFornecedores() {
    this.serviceFornecedor.obterTodos()
      .subscribe(result => {
        this.fornecedores = result;
      });
  }

  salvar() {
    this.clickSalvar = true;

    const produtoForm = Object.assign({}, this.produto, this.formulario.value);
    produtoForm.imagem = this.imagemBase64;

    if (produtoForm.id) {
      produtoForm.imagem = this.produto.imagem;
    }

    if (!produtoForm.id) {//Novo
      this.service.Novo(produtoForm)
        .subscribe(
          result => { this.router.navigate(['produtos']); },
          fail => { this.onError(fail); }
        );
    } else { //Editar
      this.service.Editar(produtoForm)
        .subscribe(
          result => { this.router.navigate(['produtos']); },
          fail => { this.onError(fail); }
        );
    }
  }

  onError(fail: HttpErrorResponse) {
    this.clickSalvar = false;
    this.errors = [];
    switch (fail.status) {
      case 0:
        const msg = 'não foi possivel se conectar ao servidor';
        console.log(msg);
        this.errors.push(msg);
        return;
      case 401:
        const msg401 = 'Token expirado';
        console.log(msg401);
        this.errors.push(msg401);
        return;
      case 500:
        const msg500 = `Foi encontrado um problema no servidor [${fail.error.Source}]`;
        console.log(msg500);
        this.errors.push(msg500);
        return;
      default:
        fail.error.erros.forEach((err: string) => {
          console.log(err);
          this.errors.push(err);
        });
        return;
    }
  }

  handleFileInput(file: FileList) {
    this.fileToUpload = file.item(0);

    const readerBase64 = new FileReader();
    readerBase64.onload = this.manipularReander.bind(this);
    readerBase64.readAsBinaryString(file[0]);
  }

  manipularReander(readerEvent: any) {
    const binaryString = readerEvent.target.result;
    this.imagemBase64 = btoa(binaryString);
  }

  voltar() {
    this.router.navigate(['/produtos']);
  }
}
