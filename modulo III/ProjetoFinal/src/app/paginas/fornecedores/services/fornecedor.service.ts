import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Fornecedor } from '../models/fornecedor';
import { environment } from 'src/environments/environment';
import { Result } from 'src/app/comum/Result';

@Injectable()
export class FornecedorService {

  private readonly urlAPI = `${environment.urlAPI}/v1/fornecedores`;

  constructor(private http: HttpClient) { }

  obterTodos(): Observable<Fornecedor[]> {
    return this.http.get<Fornecedor[]>(this.urlAPI);
  }

  obter(id: string): Observable<Fornecedor> {
    return this.http.get<Fornecedor>(`${this.urlAPI}/${id}`);
  }

  Novo(fornecedor: Fornecedor): Observable<Result<string>> {
    return this.http.post<Result<string>>(this.urlAPI, fornecedor);
  }

  Editar(fornecedor: Fornecedor): Observable<Result<string>> {
    return this.http.put<Result<string>>(`${this.urlAPI}/${fornecedor.id}`, fornecedor);
  }

  Apagar(id: string): Observable<Result<string>>{
    return this.http.delete<Result<string>>(`${this.urlAPI}/${id}`);
  }

}
