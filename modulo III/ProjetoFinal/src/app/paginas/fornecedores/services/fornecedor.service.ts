import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Fornecedor } from '../models/fornecedor';
import { environment } from 'src/environments/environment';
import { Result } from 'src/app/comum/Result';
import { SessionService } from 'src/app/comum/session.service';

@Injectable()
export class FornecedorService {

  private readonly urlAPI = `${environment.urlAPI}/v1/fornecedores`;

  constructor(
    private http: HttpClient,
    private session: SessionService
  ) { }

  obterTodos(): Observable<Fornecedor[]> {
    return this.http.get<Fornecedor[]>(this.urlAPI, this.ObterAuthHeader());
  }

  obter(id: string): Observable<Fornecedor> {
    return this.http.get<Fornecedor>(`${this.urlAPI}/${id}`, this.ObterAuthHeader());
  }

  Novo(fornecedor: Fornecedor): Observable<Result<string>> {
    return this.http.post<Result<string>>(this.urlAPI, fornecedor, this.ObterAuthHeader());
  }

  Editar(fornecedor: Fornecedor): Observable<Result<string>> {
    return this.http.put<Result<string>>(`${this.urlAPI}/${fornecedor.id}`, fornecedor, this.ObterAuthHeader());
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
