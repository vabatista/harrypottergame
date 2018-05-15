import { Component } from '@angular/core';
import { Pergunta, PerguntaAberta } from './pergunta/pergunta.component';

@Component({
  selector: 'app-root',
  template: `
    <div class="container-fluid">
      <barra-controle (selectPergunta)="onSelectPergunta()"></barra-controle>
      <pergunta [pergunta]="perguntaSelecionada"></pergunta>
    </div>
  `,
  styles: [`
    .container-fluid {
      padding-top: 70px;
    }
  `]
})
export class AppComponent {

  public perguntaSelecionada: Pergunta;
  
  public onSelectPergunta(): void {
    this.perguntaSelecionada = new PerguntaAberta("Quem o sobrenome do Harry?");
  }
}
