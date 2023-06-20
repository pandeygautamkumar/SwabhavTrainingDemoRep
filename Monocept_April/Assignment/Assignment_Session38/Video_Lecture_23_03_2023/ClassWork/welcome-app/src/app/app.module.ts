import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome.component';
import { HeaderComponent } from './header/header.component'

@NgModule({
  declarations: [
    AppComponent, WelcomeComponent, HeaderComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
