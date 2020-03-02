import { Pipe, PipeTransform } from '@angular/core';
import { Produto } from 'src/app/models/produto';

@Pipe({
  name: 'filtrarPorDescricao'
})
export class FiltrarPorDescricaoPipe implements PipeTransform {

  transform(listaProdutos: Produto[], filtro: string): Produto[] {
    
    filtro = filtro.trim().toLowerCase();

    return listaProdutos
      .filter(p => p.descricao.toLowerCase()
      .includes(filtro));
  }

}
