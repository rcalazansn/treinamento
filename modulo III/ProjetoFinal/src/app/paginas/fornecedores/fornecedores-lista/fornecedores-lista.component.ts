import { Component, OnInit } from '@angular/core';
import { Fornecedor } from '../models/fornecedor';
import { FornecedorService } from '../services/fornecedor.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-fornecedores-lista',
  templateUrl: './fornecedores-lista.component.html',
  styleUrls: ['./fornecedores-lista.component.css']
})
export class FornecedoresListaComponent implements OnInit {

  fornecedores: Fornecedor[];
  errors: string[] = [];

  constructor(private service: FornecedorService) { }

  ngOnInit() {
    this.service.obterTodos()
      .subscribe(
        result => { this.fornecedores = result; },
        fail => { this.onError(fail); }
      );
  }

  apagar(id: string) {
    // console.log(id);

    this.service.Apagar(id)
      .subscribe(
        result => { this.fornecedores = this.fornecedores.filter(f => f.id !== id); },
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
