import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';

import { utilsBr } from 'js-brasil';
import { NgBrazilValidators } from 'ng-brazil';
import { CustomValidators } from 'ng2-validation';
import { GenericValidator, DisplayMessage, ValidationMessages } from 'src/app/generic-validator';

@Component({
  selector: 'rcn-cadastro',
  templateUrl: './cadastro.component.html',
  styles: []
})
export class CadastroComponent implements OnInit {

  cadastroForm: FormGroup;

  public MASKS = utilsBr.MASKS;

  validationMessages: ValidationMessages;
  genericValidator: GenericValidator;
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

    //Fase 0
    //let nome = new FormControl('');

    //Fase 1
    // this.cadastroForm = new FormGroup({
    //   nome: new FormControl(''),
    //   email: new FormControl(''),
    //   cpf: new FormControl(''),
    //   senha: new FormControl(''),
    //   confirmarSenha: new FormControl('')
    // });

    //Fase 2
    // this.cadastroForm = this.fb.group({
    //   nome: ['', [Validators.required, CustomValidators.rangeLength([3, 15])]],
    //   email: ['', [Validators.required, Validators.email]],
    //   cpf: ['', [Validators.required, NgBrazilValidators.cpf]],
    //   senha: ['', [Validators.required, CustomValidators.rangeLength([6, 10])]],
    //   confirmarSenha: ['', [Validators.required, CustomValidators.rangeLength([6, 10])]],
    // });

    //Fase 3

    let senha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 10])]);
    let confirmarSenha = new FormControl('',
      [
        Validators.required,
        CustomValidators.rangeLength([6, 10]),
        CustomValidators.equalTo(senha)
      ]);

    this.cadastroForm = this.fb.group({
      nome: ['', [Validators.required, CustomValidators.rangeLength([3, 15])]],
      email: ['', [Validators.required, Validators.email]],
      cpf: ['', [Validators.required, NgBrazilValidators.cpf]],
      senha: ['', senha],
      confirmarSenha: ['', confirmarSenha],
    });
  }

  salvar() {
    console.log(this.cadastroForm.value);
  }
}
