import { Component, OnInit, Input } from '@angular/core';
import { PerguntaAberta } from './pergunta.component';

@Component({
  selector: 'pergunta-aberta',
  template: `
    <div class="form-group">
      <label for="pergunta-aberta">{{pergunta.texto}}</label>
      <input type="text" class="form-control" id="pergunta-aberta">
    </div>
  `,
  //styles: [``]
})
export class PerguntaAbertaComponent implements OnInit {

  @Input()
  public pergunta: PerguntaAberta;

  constructor() { }

  ngOnInit() {
  }

}
