import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FornecedoresListaComponent } from './fornecedores-lista/fornecedores-lista.component';
import { FornecedoresFormularioComponent } from './fornecedores-formulario/fornecedores-formulario.component';


const routes: Routes = [
  { path: '', component: FornecedoresListaComponent },
  { path: 'fornecedor', component: FornecedoresFormularioComponent },
  { path: 'fornecedor/:id', component: FornecedoresFormularioComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FornecedoresRoutingModule { }
