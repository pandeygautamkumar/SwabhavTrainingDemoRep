import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { WelcomeComponent } from './welcome.component';
import { HeaderComponent } from './header/header.component';
import { EventpropbindComponent } from './eventpropbind/eventpropbind.component'

@NgModule({
  declarations: [
    WelcomeComponent,
    HeaderComponent,
    EventpropbindComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
