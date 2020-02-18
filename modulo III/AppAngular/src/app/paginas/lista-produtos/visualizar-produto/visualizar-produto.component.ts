import { Component, OnInit } from '@angular/core';
import { ProdutoService } from 'src/app/services/produto.service';
import { Produto } from 'src/app/models/produto';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'rcn-visualizar-produto',
  templateUrl: './visualizar-produto.component.html'
})
export class VisualizarProdutoComponent implements OnInit {

  modelo: Produto;

  constructor
    (
      private service: ProdutoService,
      private route: ActivatedRoute,
      private router: Router
    ) { }

  ngOnInit() {
    let id = this.route.snapshot.params['id'];
    //console.log(id);

    this.service.obterProduto(id)
      .subscribe(result => {
        this.modelo = result
      });
  }

  voltar() {
    this.router.navigate(['produtos']);
  }

}
