import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'pergunta',
  template: `
    <div [ngSwitch]="pergunta?.tipo">
      <pergunta-aberta *ngSwitchCase="'aberta'" [pergunta]="pergunta"></pergunta-aberta>
      <pergunta-multipla-escolha *ngSwitchCase="'multipla-escolha'" [pergunta]="pergunta"></pergunta-multipla-escolha>
      <div *ngSwitchDefault>
        Nenhuma pergunta selecionada
      </div>
    </div>
  `,
  //styles: [``]
})
export class PerguntaComponent implements OnInit {

  @Input()
  public pergunta: Pergunta;

  constructor() { }

  ngOnInit() {
  }

}

type TipoPergunta = "aberta"|"multipla-escolha";

export abstract class Pergunta {

  public tipo: TipoPergunta;
  public texto: string;

  constructor(tipo: TipoPergunta, texto: string) {
    this.tipo = tipo;
    this.texto = texto;
  }
}

export class PerguntaAberta extends Pergunta {
  constructor(texto: string) {
    super("aberta", texto);

  }
}

export class PerguntaMultiplaEscolha extends Pergunta {

  opcoes: string[];

  constructor(texto: string, opcoes: string[]) {
    super("multipla-escolha", texto);
    this.opcoes = opcoes;
  }

}