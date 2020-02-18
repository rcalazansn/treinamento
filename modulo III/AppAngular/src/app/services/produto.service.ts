import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Produto } from '../models/produto';
import { Observable } from 'rxjs';

@Injectable()
export class ProdutoService {

  protected urlApi: string = "http://localhost:3000/produtos";

  constructor(private http: HttpClient) { }

  obterProdutos(): Observable<Produto[]> {
    return this.http.get<Produto[]>(this.urlApi);
  }

  obterProduto(id: number): Observable<Produto> {
    return this.http.get<Produto>(`${this.urlApi}/${id}`);
  }
}
