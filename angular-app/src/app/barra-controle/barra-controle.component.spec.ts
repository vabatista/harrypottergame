import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BarraControleComponent } from './barra-controle.component';

describe('BarraControleComponent', () => {
  let component: BarraControleComponent;
  let fixture: ComponentFixture<BarraControleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BarraControleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BarraControleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
