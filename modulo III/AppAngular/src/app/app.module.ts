import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { MenuComponent } from './comum/menu/menu.component';
import { FooterComponent } from './comum/footer/footer.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { ContatoComponent } from './paginas/contato/contato.component';
import { RouterModule } from '@angular/router';
import { rootRouterConfig } from './app.routes';
import { NaoEncontradaComponent } from './comum/nao-encontrada/nao-encontrada.component';
import { HomeComponent } from './paginas/home/home.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';
import { HttpClientModule } from '@angular/common/http';
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';
registerLocaleData(localePt);

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    FooterComponent,
    ListaProdutosComponent,
    ContatoComponent,
    NaoEncontradaComponent,
    HomeComponent,
    DataBindingComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    [RouterModule.forRoot(rootRouterConfig, { useHash: false })]
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
