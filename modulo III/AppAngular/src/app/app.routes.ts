
import { Routes } from '@angular/router';

//Componetes
import { ContatoComponent } from './paginas/contato/contato.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { NaoEncontradaComponent } from './comum/nao-encontrada/nao-encontrada.component';
import { HomeComponent } from './paginas/home/home.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';
import { CadastroComponent } from './exemplos/cadastro/cadastro.component';

export const rootRouterConfig: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'contato', component: ContatoComponent },
    { path: 'produtos', component: ListaProdutosComponent },
    { path: 'data-binding', component: DataBindingComponent },
    { path: 'cadastro', component: CadastroComponent },
    { path: '**', component: NaoEncontradaComponent },
];