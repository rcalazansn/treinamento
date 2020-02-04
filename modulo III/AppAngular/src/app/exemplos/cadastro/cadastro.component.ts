import { Component, OnInit, AfterViewInit, ElementRef, ViewChildren } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl, FormControlName } from '@angular/forms';
import { Usuario } from 'src/app/models/usuario';
import { NgBrazilValidators } from 'ng-brazil';

import { utilsBr } from 'js-brasil';
import { CustomValidators } from 'ng2-validation';
import { GenericValidator, ValidationMessages, DisplayMessage } from 'src/app/generic-validator';
import { Observable, fromEvent, merge } from 'rxjs';

@Component({
  selector: 'rcn-cadastro',
  templateUrl: './cadastro.component.html'
})
export class CadastroComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];

  cadastroForm: FormGroup;
  usuario: Usuario;

  MASKS = utilsBr.MASKS;

  genericValidator: GenericValidator;
  validationMessages: ValidationMessages;
  displayMessage: DisplayMessage = {};

  constructor(private fb: FormBuilder) {
    this.validationMessages = {
      nome: {
        required: 'O Nome é requerido',
        minlength: 'O Nome precisa ter no mínimo 2 caracteres',
        maxlength: 'O Nome precisa ter no máximo 60 caracteres'
      },
      cpf: {
        required: 'Informe o CPF',
        cpf: 'CPF em formato inválido'
      },
      email: {
        required: 'Informe o e-mail',
        email: 'Email inválido'
      },
      senha: {
        required: 'Informe a senha',
        rangeLength: 'A senha deve possuir entre 6 e 15 caracteres'
      },
      confirmarSenha: {
        required: 'Informe a senha novamente',
        rangeLength: 'A senha deve possuir entre 6 e 15 caracteres',
        equalTo: 'As senhas não conferem'
      }
    };

    this.genericValidator = new GenericValidator(this.validationMessages);
  }

  ngOnInit() {
    //let nome = new FormControl('');

    // this.cadastroForm = new FormGroup({
    //   nome: new FormControl(''),
    //   email: new FormControl(''),
    //   cpf: new FormControl(''),
    //   senha: new FormControl(''),
    //   confirmarSenha: new FormControl('')
    // });


    // this.cadastroForm = this.fb.group({
    //   nome: ['', Validators.required],
    //   email: ['',[Validators.required, Validators.email]],
    //   cpf: ['',[Validators.required,NgBrazilValidators.cpf]],
    //   senha: ['', CustomValidators.rangeLength([6, 15])],
    //   confirmarSenha: [''],
    // });

    let senha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 15])]);
    let confirmarSenha = new FormControl('',
      [
        Validators.required,
        CustomValidators.rangeLength([6, 15]),
        CustomValidators.equalTo(senha)
      ]);

    this.cadastroForm = this.fb.group({
      nome: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      cpf: ['', [Validators.required, NgBrazilValidators.cpf]],
      senha: senha,
      confirmarSenha: confirmarSenha,
    });
  }

  ngAfterViewInit(): void {
    let controlBlurs: Observable<any>[] = this.formInputElements
      .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(() => {
      this.displayMessage = this.genericValidator.processarMensagens(this.cadastroForm);
    });
  }

  salvar() {
    // let x = this.cadastroForm.value;

    this.usuario = Object.assign({}, this.usuario, this.cadastroForm.value);
  }

}
