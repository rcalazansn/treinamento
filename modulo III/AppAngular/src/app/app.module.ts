import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MenuComponent } from './comum/menu/menu.component';
import { FooterComponent } from './comum/footer/footer.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { ContatoComponent } from './paginas/contato/contato.component';
import { RouterModule } from '@angular/router';
import { rootRouterConfig } from './app.routes';
import { NaoEncontradaComponent } from './comum/nao-encontrada/nao-encontrada.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    FooterComponent,
    ListaProdutosComponent,
    ContatoComponent,
    NaoEncontradaComponent
  ],
  imports: [
    BrowserModule,
    [RouterModule.forRoot(rootRouterConfig, {useHash: false})]
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
