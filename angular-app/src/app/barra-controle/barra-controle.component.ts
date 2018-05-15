import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'barra-controle',
  template: `
    <nav class="navbar fixed-top navbar-light bg-light">
      <button type="button" class="btn btn-primary" (click)="selecionarPergunta()">Selecionar Pergunta</button>
    </nav>
  `,
  //styles: [``]
})
export class BarraControleComponent implements OnInit {

  @Output()
  selectPergunta: EventEmitter<void> = new EventEmitter<void>();

  constructor() { }

  ngOnInit() {
  }

  public selecionarPergunta(): void {
    this.selectPergunta.emit();
  }

}
