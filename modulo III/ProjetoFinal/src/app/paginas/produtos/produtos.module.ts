import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProdutosRoutingModule } from './produtos-routing.module';
import { ProdutosListaComponent } from './produtos-lista/produtos-lista.component';
import { ProdutosFormularioComponent } from './produtos-formulario/produtos-formulario.component';
import { ProdutoService } from './services/produto.service';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { FornecedorService } from '../fornecedores/services/fornecedor.service';


@NgModule({
  declarations: [ProdutosListaComponent, ProdutosFormularioComponent],
  imports: [
    CommonModule,
    ProdutosRoutingModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [
    ProdutoService,
    FornecedorService
  ]
})
export class ProdutosModule { }
