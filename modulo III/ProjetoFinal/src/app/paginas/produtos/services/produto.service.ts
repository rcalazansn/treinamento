import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Produto } from '../models/produto';
import { environment } from 'src/environments/environment';
import { SessionService } from 'src/app/comum/session.service';
import { Observable } from 'rxjs';
import { Result } from 'src/app/comum/Result';

@Injectable()
export class ProdutoService {

  private readonly urlAPI = `${environment.urlAPI}/v1/produtos`;

  constructor(
    private http: HttpClient,
    private session: SessionService) { }

  obterTodos(): Observable<Produto[]> {
    return this.http.get<Produto[]>(this.urlAPI, this.ObterAuthHeader());
  }

  obter(id: string): Observable<Produto> {
    return this.http.get<Produto>(`${this.urlAPI}/${id}`, this.ObterAuthHeader());
  }

  Novo(produto: Produto): Observable<Result<string>> {
    return this.http.post<Result<string>>(this.urlAPI, produto, this.ObterAuthHeader());
  }

  Editar(produto: Produto): Observable<Result<string>> {
    return this.http.put<Result<string>>(`${this.urlAPI}/${produto.id}`, produto, this.ObterAuthHeader());
  }

  Apagar(id: string): Observable<Result<string>> {
    return this.http.delete<Result<string>>(`${this.urlAPI}/${id}`, this.ObterAuthHeader());
  }

  protected ObterAuthHeader() {
    return {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: `Bearer ${this.session.obterToken()}`
      })
    };
  }
}
