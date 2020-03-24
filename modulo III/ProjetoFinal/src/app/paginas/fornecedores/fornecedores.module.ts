import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { NgxMaskModule } from 'ngx-mask';

import { FornecedoresRoutingModule } from './fornecedores-routing.module';
import { FornecedoresListaComponent } from './fornecedores-lista/fornecedores-lista.component';
import { FornecedoresFormularioComponent } from './fornecedores-formulario/fornecedores-formulario.component';
import { FornecedorService } from './services/fornecedor.service';


@NgModule({
  declarations: [FornecedoresListaComponent, FornecedoresFormularioComponent],
  imports: [
    CommonModule,
    FornecedoresRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    NgxMaskModule.forRoot()
  ],
  providers: [
    FornecedorService
  ]
})
export class FornecedoresModule { }
