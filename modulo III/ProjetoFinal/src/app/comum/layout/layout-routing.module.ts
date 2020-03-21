import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LayoutComponent } from './layout.component';
import { HomeComponent } from '../home/home.component';

const routes: Routes = [
  {
    path: '', component: LayoutComponent,
    children: [
      { path: '', component: HomeComponent },
      {
        path: 'fornecedores',
        loadChildren: () => import('../../paginas/fornecedores/fornecedores.module')
          .then(m => m.FornecedoresModule)
      },
      {
        path: 'produtos',
        loadChildren: () => import('../../paginas/produtos/produtos.module')
          .then(m => m.ProdutosModule)
      }
    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutRoutingModule { }
