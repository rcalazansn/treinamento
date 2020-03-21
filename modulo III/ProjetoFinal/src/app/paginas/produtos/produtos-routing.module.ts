import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProdutosListaComponent } from './produtos-lista/produtos-lista.component';
import { ProdutosFormularioComponent } from './produtos-formulario/produtos-formulario.component';


const routes: Routes = [
  { path: '', component: ProdutosListaComponent },
  { path: 'produto', component: ProdutosFormularioComponent },
  { path: 'produto/:id', component: ProdutosFormularioComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProdutosRoutingModule { }
