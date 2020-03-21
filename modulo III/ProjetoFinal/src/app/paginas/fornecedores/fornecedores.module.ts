import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FornecedoresRoutingModule } from './fornecedores-routing.module';
import { FornecedoresListaComponent } from './fornecedores-lista/fornecedores-lista.component';
import { FornecedoresFormularioComponent } from './fornecedores-formulario/fornecedores-formulario.component';
import { FornecedorService } from './services/fornecedor.service';


@NgModule({
  declarations: [FornecedoresListaComponent, FornecedoresFormularioComponent],
  imports: [
    CommonModule,
    FornecedoresRoutingModule
  ],
  providers: [
    FornecedorService
  ]
})
export class FornecedoresModule { }
