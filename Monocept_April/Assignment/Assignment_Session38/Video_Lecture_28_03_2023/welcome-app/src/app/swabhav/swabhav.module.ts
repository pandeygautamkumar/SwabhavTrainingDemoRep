import { NgModule } from '@angular/core';
//import { CommonModule } from '@angular/common';
import { WishComponent } from './wish/wish.component';
import { BrowserModule } from '@angular/platform-browser';
import { SnakePipe } from './snake.pipe';
import { FormsModule } from '@angular/forms';
import { TowaybindComponent } from './towaybind/towaybind.component';
import { ProductListComponent } from './product/product.list.component';
import { ProductService } from './product/product.service';



@NgModule({
  declarations: [
    WishComponent,
    SnakePipe,
    TowaybindComponent,
    ProductListComponent
  ],
  imports: [
    //CommonModule      // Contain if statement,for loop etc basic thing
    BrowserModule,
    FormsModule
  ],
  exports: [
    BrowserModule,
    WishComponent,
    SnakePipe,
    TowaybindComponent,
    ProductListComponent
  ],
  providers:[
    ProductService
  ]
})
export class SwabhavModule { }
