import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FornecedoresFormularioComponent } from './fornecedores-formulario.component';

describe('FornecedoresFormularioComponent', () => {
  let component: FornecedoresFormularioComponent;
  let fixture: ComponentFixture<FornecedoresFormularioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FornecedoresFormularioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FornecedoresFormularioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
