import { Injectable } from '@angular/core';
import { Product } from './product';

@Injectable()
export class ProductService {
  products: Array<Product> = new Array<Product>
  constructor() {
    console.log("Product Service Created");
    this.products.push(new Product(101, "Book", 100))
    this.products.push(new Product(102, "Pen", 20))
    this.products.push(new Product(103, "Choclates", 300))
  }
  getProducts(): Array<Product> {
    return this.products;
  }
  getById(id: number) {
    let p = this.products.find(p => p.id === id)
    return p;
  }
}
