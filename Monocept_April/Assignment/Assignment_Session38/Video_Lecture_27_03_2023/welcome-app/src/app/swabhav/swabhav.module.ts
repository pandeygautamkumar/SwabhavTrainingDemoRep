import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WishComponent } from './wish/wish.component';
import { BrowserModule } from '@angular/platform-browser';
import { SnakePipe } from './snake.pipe';



@NgModule({
  declarations: [
    WishComponent,
    SnakePipe
  ],
  imports: [
    //CommonModule      // Contain if statement,for loop etc basic thing
    BrowserModule
  ],
  exports: [
    BrowserModule,
    WishComponent,
    SnakePipe
  ]
})
export class SwabhavModule { }
