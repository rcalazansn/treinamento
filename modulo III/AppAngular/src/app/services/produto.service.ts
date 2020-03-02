import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Produto } from '../models/produto';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable()
export class ProdutoService {

  protected urlApi: string = environment.urlApi;

  constructor(private http: HttpClient) { }

  obterProdutos(): Observable<Produto[]> {
    return this.http.get<Produto[]>(this.urlApi);
  }

  obterProduto(id: number): Observable<Produto> {
    return this.http.get<Produto>(`${this.urlApi}/${id}`);
  }

  EnviarLogServidor(log: Log) {
    //
  }
}

export class Log {
  message: string;
  stack: string;
  url:string;
  usuario:string;
}
