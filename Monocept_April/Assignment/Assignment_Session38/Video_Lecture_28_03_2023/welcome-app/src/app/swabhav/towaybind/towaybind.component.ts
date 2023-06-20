import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product/product.service';

@Component({
  selector: 'app-towaybind',
  templateUrl: 'towaybind.component.html',
  styleUrls: ['./towaybind.component.css']
})
export class TowaybindComponent implements OnInit {
  firstName = ""
  lastName = ""
  city: string = ""
  gender: string = "";

  constructor(public service: ProductService) {

  }

  updateFirstNameHandler(newFirstName: string) {
    console.log(newFirstName)
    this.firstName = newFirstName
  }
  ngOnInit(): void {
    console.log(this.service.getById(101))
  }
}
