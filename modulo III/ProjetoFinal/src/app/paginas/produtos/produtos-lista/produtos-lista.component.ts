import { Component, OnInit } from '@angular/core';
import { Produto } from '../models/produto';
import { ProdutoService } from '../services/produto.service';
import { Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-produtos-lista',
  templateUrl: './produtos-lista.component.html'
})
export class ProdutosListaComponent implements OnInit {

  errors: string[] = [];

  produtos: Produto[];

  constructor(
    private service: ProdutoService,
    private router: Router
  ) { }

  ngOnInit() {

    this.service.obterTodos()
      .subscribe(
        result => { this.produtos = result; },
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

  apagarProduto(id: string) {
    this.service.Apagar(id)
      .subscribe(
        result => { this.produtos = this.produtos.filter(p => p.id !== id); },
        fail => { this.onError(fail); }
      );
  }

}
