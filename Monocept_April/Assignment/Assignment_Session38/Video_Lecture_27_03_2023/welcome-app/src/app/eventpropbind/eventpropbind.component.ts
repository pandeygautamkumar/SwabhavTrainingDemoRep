import { Component } from '@angular/core';

@Component({
  selector: 'pro-eventpropbind',
  templateUrl: './eventpropbind.component.html',
  styleUrls: ['./eventpropbind.component.css']
})
export class EventpropbindComponent {
  title = "This is Event () & Property [] binding App"
  count = 0
  divColor = "black"
  clickHandler() {
    this.count += 1;
    if (this.count == 10) {
      alert("Limit Crossed")
      this.count = 0
    }
  }
  changeDivColor(color: string) {
    this.divColor = color
  }
}
