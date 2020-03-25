import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class SessionService {

  constructor(private router: Router) { }

  autenticado(): boolean {
    if (localStorage.getItem('rcn.token') !== null) {
      return true;
    }
    this.router.navigate(['/login']);
    return false;
  }

  obterToken(): string {
    return localStorage.getItem('rcn.token');
  }

  logout() {
    localStorage.removeItem('rcn.token');
  }
}
