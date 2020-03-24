import { Component, OnInit, AfterViewInit, ElementRef, ViewChildren } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators, FormControlName } from '@angular/forms';
import { Fornecedor } from '../models/fornecedor';
import { FornecedorService } from '../services/fornecedor.service';
import { HttpErrorResponse } from '@angular/common/http';
import { GenericValidator, ValidationMessages, DisplayMessage } from 'src/app/comum/generic-validator';
import { Observable, fromEvent, merge } from 'rxjs';

@Component({
  selector: 'app-fornecedores-formulario',
  templateUrl: './fornecedores-formulario.component.html'
})
export class FornecedoresFormularioComponent implements OnInit, AfterViewInit {

  titulo = 'Novo Fornecedor';
  fornecedor: Fornecedor;
  formulario: FormGroup;
  errors: string[] = [];

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];
  genericValidator: GenericValidator;
  validationMessages: ValidationMessages;
  displayMessage: DisplayMessage = {};

  clickSalvar: boolean;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder,
    private service: FornecedorService
  ) { this.AddValidationMessages(); }

  ngOnInit() {
    this.createForm();

    const id = this.route.snapshot.paramMap.get('id');

    if (id) {
      this.titulo = 'Editar Fornecedor';

      this.service.obter(id)
        .subscribe(result => {
          this.fornecedor = result;
          this.formulario.patchValue(this.fornecedor);
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
      nome: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(100)]],
      documento: ['', [Validators.required, Validators.minLength(11), Validators.maxLength(14)]],
      ativo: [false],
      tipoFornecedor: ['', [Validators.required]]
    });
  }

  AddValidationMessages() {
    this.validationMessages = {
      nome: {
        required: 'Nome é requirido',
        minlength: 'Mínimo de 2 caracteres',
        maxlength: 'Máximo de 100 caracteres'
      },
      documento: {
        required: 'Nome é requirido',
        minlength: 'Mínimo de 11 caracteres',
        maxlength: 'Máximo de 14 caracteres'
      },
      tipoFornecedor: {
        required: 'Nome é requirido'
      }
    };

    this.genericValidator = new GenericValidator(this.validationMessages);
  }

  voltar() {
    this.router.navigate(['/fornecedores']);
  }

  salvar() {

    //alert(JSON.stringify(this.formulario.getRawValue()));

    this.clickSalvar = true;

    const fornecedorForm = Object.assign({}, this.fornecedor, this.formulario.value);

    if (!fornecedorForm.id) {//Novo
      this.service.Novo(fornecedorForm)
        .subscribe(
          result => { this.router.navigate(['fornecedores']); },
          fail => { this.onError(fail); }
        );
    } else { //Editar
      this.service.Editar(fornecedorForm)
        .subscribe(
          result => { this.router.navigate(['fornecedores']); },
          fail => { this.onError(fail); }
        );
    }
  }

  onError(fail: HttpErrorResponse) {
    //console.log(fail);

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

}
