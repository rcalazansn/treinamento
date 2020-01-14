
import { Routes } from '@angular/router';

//Componetes
import { ContatoComponent } from './paginas/contato/contato.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { NaoEncontradaComponent } from './comum/nao-encontrada/nao-encontrada.component';

export const rootRouterConfig: Routes = [
    { path: '', redirectTo: '/produtos', pathMatch: 'full' },
    { path: 'contato', component: ContatoComponent },
    { path: 'produtos', component: ListaProdutosComponent },
    { path: '**', component: NaoEncontradaComponent },
];