
import { Routes } from '@angular/router';

//Componetes
import { ContatoComponent } from './paginas/contato/contato.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { NaoEncontradaComponent } from './comum/nao-encontrada/nao-encontrada.component';
import { HomeComponent } from './paginas/home/home.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';

export const rootRouterConfig: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'contato', component: ContatoComponent },
    { path: 'produtos', component: ListaProdutosComponent },
    { path: 'data-binding', component: DataBindingComponent },
    { path: '**', component: NaoEncontradaComponent },
];