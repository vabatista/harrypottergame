import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BarraControleComponent } from './barra-controle/barra-controle.component';
import { PerguntaComponent } from './pergunta/pergunta.component';
import { PerguntaAbertaComponent } from './pergunta/pergunta-aberta.component';
import { PerguntaMultiplaEscolhaComponent } from './pergunta/pergunta-multipla-escolha.component';

@NgModule({
  declarations: [
    AppComponent,
    BarraControleComponent,
    PerguntaComponent,
    PerguntaAbertaComponent,
    PerguntaMultiplaEscolhaComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
