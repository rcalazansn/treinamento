import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { Produto } from 'src/app/models/produto';
import { ProdutoService } from 'src/app/services/produto.service';

@Injectable()
export class ListaProdutosResolver implements Resolve<Observable<Produto[]>> {

    constructor(private service: ProdutoService) { }

    resolve() {
        return this.service.obterProdutos();
    }
}