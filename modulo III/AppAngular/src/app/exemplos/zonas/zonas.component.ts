import { Component, NgZone } from '@angular/core';

@Component({
  selector: 'rcn-zonas',
  templateUrl: './zonas.component.html'
})
export class ZonasComponent {

  progresso: number = 0;
  label: string;

  constructor(private ngZone: NgZone) { }

  dentroZonaAngular() {
    this.label = 'Dentro da zona Angular';
    this.progresso = 0;
    this.realizarProcessamento(() => console.log('Dentro da zona Angular - Finalizado!'));
  }

  foraZonaAngular() {
    this.label = 'Fora da zona Angular';
    this.progresso = 0;

    this.ngZone.runOutsideAngular(() => {
      this.realizarProcessamento(() => {
        this.ngZone.run(() => { console.log('Fora da zona Angular - Finalizado!'); });
      });
    });
  }

  realizarProcessamento(processoFinalizado: () => void) {
    this.progresso += 1;
    console.log(`Progresso: ${this.progresso}%`);

    if (this.progresso < 100) {
      window.setTimeout(() => this.realizarProcessamento(processoFinalizado), 10);
    } else {
      processoFinalizado();
    }
  }


}
