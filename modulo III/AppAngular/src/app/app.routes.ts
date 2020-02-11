
import { Routes, RouterModule } from '@angular/router';

//Componetes
import { ContatoComponent } from './paginas/contato/contato.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { NaoEncontradaComponent } from './comum/nao-encontrada/nao-encontrada.component';
import { HomeComponent } from './paginas/home/home.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';
import { CadastroComponent } from './exemplos/cadastro/cadastro.component';
import { NgModule } from '@angular/core';

const rootRouterConfig: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'contato', component: ContatoComponent },

    {
        path: 'produtos',
        loadChildren: () => import('./paginas/lista-produtos/lista-produtos.module')
            .then(m => m.ListaProdutosModule)
    },


    { path: 'data-binding', component: DataBindingComponent },
    { path: 'cadastro', component: CadastroComponent },
    { path: '**', component: NaoEncontradaComponent },
];

@NgModule({
    imports: [
        RouterModule.forRoot(rootRouterConfig)
    ],
    exports: [
        RouterModule
    ]
})
export class AppRoutingModule { }

