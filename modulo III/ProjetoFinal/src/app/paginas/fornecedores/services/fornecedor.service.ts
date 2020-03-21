import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Fornecedor } from '../models/fornecedor';
import { environment } from 'src/environments/environment';

@Injectable()
export class FornecedorService {

  private readonly urlAPI = `${environment.urlAPI}/v1/fornecedores`;

  constructor(private http: HttpClient) { }

  obterTodos(): Observable<Fornecedor[]> {
    console.log('=>>>>.', this.urlAPI);

    return this.http.get<Fornecedor[]>(this.urlAPI);
  }
}
