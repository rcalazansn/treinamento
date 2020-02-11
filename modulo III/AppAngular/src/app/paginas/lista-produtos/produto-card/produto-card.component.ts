import { Component,  Input, Output, EventEmitter } from '@angular/core';
import { Produto } from 'src/app/models/produto';

@Component({
  selector: 'rcn-produto-card',
  templateUrl: './produto-card.component.html',
  styles: []
})
export class ProdutoCardComponent  {

  @Input()
  produto: Produto;

  @Output()
  selecionado: EventEmitter<Produto> = new EventEmitter();

  comprar() {
    this.selecionado.emit(this.produto);
  }
}
