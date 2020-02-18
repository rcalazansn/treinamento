import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListaProdutosComponent } from './lista-produtos.component';
import { VisualizarProdutoComponent } from './visualizar-produto/visualizar-produto.component';
import { ProdutoAppComponent } from './produto.app.component';
import { ListaProdutosResolver } from './lista-produtos.resolver';


const routes: Routes = [
  {
    path: '', component: ProdutoAppComponent,
    children: [
      {
        path: '', component: ListaProdutosComponent,
        resolve:
        {
          produtos: ListaProdutosResolver
        }
      },
      { path: 'visualizar/:id', component: VisualizarProdutoComponent }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ListaProdutosRoutingModule { }
