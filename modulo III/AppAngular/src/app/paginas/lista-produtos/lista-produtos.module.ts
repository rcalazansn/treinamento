import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ListaProdutosRoutingModule } from './lista-produtos-routing.module';

import { ListaProdutosComponent } from './lista-produtos.component';
import { ProdutoCardComponent } from './produto-card/produto-card.component';
import { TotalProdutoPromocaoComponent } from './total-produto-promocao/total-produto-promocao.component';
import { ProdutoService } from 'src/app/services/produto.service';
import { VisualizarProdutoComponent } from './visualizar-produto/visualizar-produto.component';
import { ProdutoAppComponent } from './produto.app.component';
import { ListaProdutosResolver } from './lista-produtos.resolver';
import { FiltrarPorDescricaoPipe } from './filtrar-por-descricao.pipe';


@NgModule({
  declarations: [
    ListaProdutosComponent,
    ProdutoCardComponent,
    TotalProdutoPromocaoComponent,
    VisualizarProdutoComponent,
    ProdutoAppComponent,
    FiltrarPorDescricaoPipe
  ],
  imports: [
    CommonModule,
    ListaProdutosRoutingModule
    
  ],
  providers:[
    ProdutoService,
    ListaProdutosResolver
  ]
})
export class ListaProdutosModule { }
