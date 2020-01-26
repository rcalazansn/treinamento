import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/app/models/produto';
import { ProdutoService } from 'src/app/services/produto.service';

@Component({
  selector: 'rcn-lista-produtos',
  templateUrl: './lista-produtos.component.html'
})
export class ListaProdutosComponent implements OnInit {

  public listaProdutos: Produto[];

  constructor(private produtosService: ProdutoService) { }

  ngOnInit() {
    this.produtosService.obterProdutos()
      .subscribe(prd => {
        this.listaProdutos = prd;
        console.log(prd);
      },
        error => console.log(error)
      );
  }


}
