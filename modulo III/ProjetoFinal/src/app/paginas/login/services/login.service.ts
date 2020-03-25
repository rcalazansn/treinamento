import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Login, Registrar } from '../models/login';
import { Result } from 'src/app/comum/Result';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private readonly urlAPI = `${environment.urlAPI}/auth`;

  constructor(private http: HttpClient) { }

  login(login: Login): Observable<Result<string>> {
    return this.http.post<Result<string>>(`${this.urlAPI}/login`, login);
  }

  registrar(registrar: Registrar) {
    return this.http.post<Result<string>>(`${this.urlAPI}/regitrar`, registrar);
  }
}
