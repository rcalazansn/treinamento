import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Navegacao } from './navegacao';

@Component({
  selector: 'rcn-menu',
  templateUrl: './menu.component.html'
})
export class MenuComponent implements OnInit {

  Menu: Navegacao[] = [];

  constructor() { }

  ngOnInit() {
    this.Menu.push({ descricao: 'Cadastro', icone: 'fa fa-hand-spock-o', link: '/cadastro' });
    this.Menu.push({ descricao: 'DataBinding', icone: 'fa fa-hand-spock-o', link: '/data-binding' });
    this.Menu.push({ descricao: 'Produtos', icone: 'fa fa-picture-o', link: '/produtos' });
    this.Menu.push({ descricao: 'Contato', icone: 'fa fa-bullhorn', link: '/contato' });
    this.Menu.push({ descricao: 'Admin', icone: 'fa fa-cogs', link: '/admin' });
  }



}
