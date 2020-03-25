import { Component, OnInit } from '@angular/core';
import { Login } from './models/login';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { LoginService } from './services/login.service';
import { Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  errors: string[] = [];
  objlogin: Login;
  formulario: FormGroup;

  constructor(
    private fb: FormBuilder,
    private service: LoginService,
    private router: Router
  ) { }

  ngOnInit() {
    this.createForm();
  }

  createForm() {
    this.formulario = this.fb.group({
      login: ['diego', [Validators.required]],
      senha: ['diego.Moises123', [Validators.required]]
    });
  }

  login() {
    const loginForm = Object.assign({}, this.objlogin, this.formulario.value);

    this.service.login(loginForm)
      .subscribe(
        result => {
          localStorage.setItem('rcn.token', result.data);
          this.router.navigate(['/']);
        },
        fail => { this.onError(fail); }
      );
  }
  onError(fail: HttpErrorResponse) {

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
