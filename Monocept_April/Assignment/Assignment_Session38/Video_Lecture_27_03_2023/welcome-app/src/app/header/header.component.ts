import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  title = "Monocept"
  location = "Hyderabad"
  constructor() {
    console.log("Inside Constructor")
  }
  ngOnInit(): void {

    setTimeout(() => {
      this.title = "Swabhav"
      this.location = "Mumbai"
    }, 3000);
  }
}
