import { Component, OnInit, Input } from '@angular/core';
import { PerguntaMultiplaEscolha } from './pergunta.component';

@Component({
  selector: 'pergunta-multipla-escolha',
  template: `
    <div class="form-group">
      <label for="pergunta-multipla-escolha">{{pergunta.texto}}</label>
      <div class="form-check" *ngFor="let opcao of pergunta.opcoes">
        <input class="form-check-input" type="radio" name="resposta" id="opcao-{{opcao}}" value="opcao">
        <label class="form-check-label" for="opcao-{{opcao}}">
          {{opcao}}
        </label>
      </div>
    </div>
  `,
  //styles: [``]
})
export class PerguntaMultiplaEscolhaComponent implements OnInit {

  @Input()
  public pergunta: PerguntaMultiplaEscolha;

  constructor() { }

  ngOnInit() {
  }

}


