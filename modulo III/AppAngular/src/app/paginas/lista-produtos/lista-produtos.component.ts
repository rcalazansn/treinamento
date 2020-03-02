import { Component, OnInit, OnDestroy } from '@angular/core';
import { Produto } from 'src/app/models/produto';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { debounceTime } from 'rxjs/operators'

@Component({
  selector: 'rcn-lista-produtos',
  templateUrl: './lista-produtos.component.html'
})
export class ListaProdutosComponent implements OnInit, OnDestroy {
  public listaProdutos: Produto[];

  filtro:string='';
  debounce:Subject<string>= new Subject<string>();

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {

    this.debounce
    .pipe(debounceTime(300))
    .subscribe(f=>{
			this.filtro = f;
    });
    
    this.listaProdutos = this.route.snapshot.data['produtos'];
  }

  ngOnDestroy(): void {
    this.debounce.unsubscribe();
  }

  produtoSelecionado(prd: Produto) {
    console.log('=>', event);

    prd.promocao = !prd.promocao;
  }


}
