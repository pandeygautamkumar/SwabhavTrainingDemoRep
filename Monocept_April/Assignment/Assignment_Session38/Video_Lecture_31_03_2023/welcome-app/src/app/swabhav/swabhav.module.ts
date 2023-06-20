import { NgModule } from '@angular/core';
//import { CommonModule } from '@angular/common';
import { WishComponent } from './wish/wish.component';
import { BrowserModule } from '@angular/platform-browser';
import { SnakePipe } from './snake.pipe';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TowaybindComponent } from './towaybind/towaybind.component';
import { ProductListComponent } from './product/product.list.component';
import { ProductService } from './product/product.service';
import { NumberapiComponent } from './numberapi/numberapi.component';
import { HttpClientModule } from '@angular/common/http';
import { NumberapisvcService } from './numberapi/numberapisvc.service';
import { LoginComponent } from './login/login.component';
import { StarComponent } from './star/star.component';

@NgModule({
  declarations: [
    WishComponent,
    SnakePipe,
    TowaybindComponent,
    ProductListComponent,
    NumberapiComponent,
    LoginComponent,
    StarComponent
  ],
  imports: [
    //CommonModule      // Contain if statement,for loop etc basic thing
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  exports: [
    BrowserModule,
    WishComponent,
    SnakePipe,
    TowaybindComponent,
    ProductListComponent,
    NumberapiComponent,
    LoginComponent,
    StarComponent
  ],
  providers: [
    ProductService,
    NumberapisvcService
  ]
})
export class SwabhavModule { }
