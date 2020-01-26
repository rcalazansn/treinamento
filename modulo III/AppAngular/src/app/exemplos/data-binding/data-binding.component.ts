import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'rcn-data-binding',
  templateUrl: './data-binding.component.html'
})
export class DataBindingComponent implements OnInit {

 public contador: number = 0;
 public urlImagem:string="https://i.ya-webdesign.com/images/50-x-50-png-log-9.png";


  constructor() { }

  ngOnInit() {
  }

  incrementarContador(){
    this.contador++;
  }

  zerarContador(){
    this.contador =0;
  }

}
