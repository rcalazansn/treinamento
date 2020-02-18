import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { CadastroComponent } from './cadastro.component';

@Injectable()
export class CadastroGuardService implements CanDeactivate<CadastroComponent> {

  canDeactivate(component: CadastroComponent): boolean {
    if (component.alteracoesPendentes)
      return window.confirm('Deseja abandonar o preechimento do cadastro?');

    return true;
  }

  constructor() { }
}
