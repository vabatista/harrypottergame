import { Component } from '@angular/core';
import { Pergunta, PerguntaAberta, PerguntaMultiplaEscolha } from './pergunta/pergunta.component';

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
    if (Math.random() < 0.5)
      this.perguntaSelecionada = new PerguntaAberta("Qual é o sobrenome do Harry?");
    else
      this.perguntaSelecionada = new PerguntaMultiplaEscolha("Qual objeto um bruxo utiliza para voar?", [
        "Tapete",
        "Vassoura",
        "A nuvem do Goku",
        "Avião"
      ]);
  }
}
