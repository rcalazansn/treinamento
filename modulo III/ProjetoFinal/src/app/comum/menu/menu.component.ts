import { Component, OnInit } from '@angular/core';
import { SessionService } from '../session.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html'
})
export class MenuComponent implements OnInit {

  navBarOpen = false;
  constructor(
    private session: SessionService,
    private router: Router
  ) { }

  ngOnInit() {
    this.session.autenticado();
  }

  logout() {
    this.session.logout();
    this.router.navigate(['/login']);

  }

  toggleNavbar(){
    this.navBarOpen = !this.navBarOpen;
  }
}
