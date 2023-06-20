import { NgModule } from '@angular/core';
//import { CommonModule } from '@angular/common';
import { WishComponent } from './wish/wish.component';
import { BrowserModule } from '@angular/platform-browser';
import { SnakePipe } from './snake.pipe';
import { FormsModule } from '@angular/forms';
import { TowaybindComponent } from './towaybind/towaybind.component';
import { ProductListComponent } from './product/product.list.component';
import { ProductService } from './product/product.service';
import { NumberapiComponent } from './numberapi/numberapi.component';
import { HttpClientModule } from '@angular/common/http';
import { NumberapisvcService } from './numberapi/numberapisvc.service';

@NgModule({
  declarations: [
    WishComponent,
    SnakePipe,
    TowaybindComponent,
    ProductListComponent,
    NumberapiComponent
  ],
  imports: [
    //CommonModule      // Contain if statement,for loop etc basic thing
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  exports: [
    BrowserModule,
    WishComponent,
    SnakePipe,
    TowaybindComponent,
    ProductListComponent,
    NumberapiComponent
  ],
  providers: [
    ProductService,
    NumberapisvcService
  ]
})
export class SwabhavModule { }
