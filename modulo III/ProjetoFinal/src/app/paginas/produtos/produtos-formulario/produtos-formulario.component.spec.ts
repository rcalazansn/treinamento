import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutosFormularioComponent } from './produtos-formulario.component';

describe('ProdutosFormularioComponent', () => {
  let component: ProdutosFormularioComponent;
  let fixture: ComponentFixture<ProdutosFormularioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProdutosFormularioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProdutosFormularioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
