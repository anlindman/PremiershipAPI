import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PlayerComponent } from './player/player.component';
import { PlayerFormComponent } from './player/player-form/player-form.component';

@NgModule({
  declarations: [
    AppComponent,
    PlayerComponent,
    PlayerFormComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
