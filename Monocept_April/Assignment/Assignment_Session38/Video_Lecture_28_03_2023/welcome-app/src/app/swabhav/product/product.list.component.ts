import { Component, OnInit } from '@angular/core';
import { ProductService } from './product.service';
import { Product } from './product';

@Component({
  selector: 'app-product',
  templateUrl: './product.list.component.html'
})
export class ProductListComponent implements OnInit {
  products: Array<Product> = new Array<Product>
  constructor(private productService: ProductService) {

  }
  ngOnInit(): void {
    this.products=this.productService.getProducts();
  }
}
