import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'barra-controle',
  template: `
    <nav class="navbar fixed-top navbar-light bg-light">
      <button type="button" class="btn btn-primary" (click)="selecionarPergunta()">Selecionar Pergunta</button>
      <span class="contador">{{contador}}</span>
    </nav>
  `,
  styles: [`
    span.contador {
      font-size: 1.5em;
    }
  `]
})
export class BarraControleComponent implements OnInit {

  @Output()
  selectPergunta: EventEmitter<void> = new EventEmitter<void>();
  
  @Output()
  tempoEsgotado: EventEmitter<void> = new EventEmitter<void>();

  contador: number;

  constructor() { }

  ngOnInit() {
  }

  public selecionarPergunta(): void {
    this.selectPergunta.emit();
    this.iniciarContador(60);
  }

  private iniciarContador(valor: number): void {
    this.contador = valor;
    this.tick();
  }

  private tick(): void {
    this.contador--;
    if (this.contador > 0) {
      setTimeout(() => this.tick(), 1000);
    }
    else {
      this.tempoEsgotado.emit();
    }
  }
}
