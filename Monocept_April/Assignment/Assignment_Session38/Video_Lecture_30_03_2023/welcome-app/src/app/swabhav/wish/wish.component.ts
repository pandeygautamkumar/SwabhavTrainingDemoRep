import { Component } from '@angular/core';

@Component({
  selector: 'app-wish',
  templateUrl: './wish.component.html',
})
export class WishComponent {
  today = Date.now()
  message: string = "Hello"
  wishHandler(user: string) {
    this.message += "," + user.toUpperCase() + " all yours wishes will come true.";
  }
}
