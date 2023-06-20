import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'sw-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent {
  @Input()
  rating: number
  @Output()
  ratingClicked: EventEmitter<string> = new EventEmitter<string>();
  constructor() {
    this.rating = 4.5;
  }
  clickHandler(e: Event) {
    console.log("Inside Click Handler of Child.")
    // console.log(e)
    this.ratingClicked.emit('The rating value is : ' + this.rating);
  }
}
