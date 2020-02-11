import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ListaProdutosRoutingModule } from './lista-produtos-routing.module';

import { ListaProdutosComponent } from './lista-produtos.component';
import { ProdutoCardComponent } from './produto-card/produto-card.component';
import { TotalProdutoPromocaoComponent } from './total-produto-promocao/total-produto-promocao.component';


@NgModule({
  declarations: [
    ListaProdutosComponent,
    ProdutoCardComponent,
    TotalProdutoPromocaoComponent
  ],
  imports: [
    CommonModule,
    ListaProdutosRoutingModule
  ]
})
export class ListaProdutosModule { }
