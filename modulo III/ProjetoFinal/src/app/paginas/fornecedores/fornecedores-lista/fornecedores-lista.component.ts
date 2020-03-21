import { Component, OnInit } from '@angular/core';
import { Fornecedor } from '../models/fornecedor';
import { FornecedorService } from '../services/fornecedor.service';

@Component({
  selector: 'app-fornecedores-lista',
  templateUrl: './fornecedores-lista.component.html',
  styleUrls: ['./fornecedores-lista.component.css']
})
export class FornecedoresListaComponent implements OnInit {

  fornecedores: Fornecedor[];

  constructor(private service: FornecedorService) { }

  ngOnInit() {
    this.service.obterTodos()
      .subscribe(
        result => { this.fornecedores = result; },
        fail => { console.log(fail); }
      );
  }

}
