import { Component, OnInit } from '@angular/core';
import { NumberapisvcService } from './numberapisvc.service';

@Component({
  selector: 'sw-numberapi',
  templateUrl: './numberapi.component.html'
})
export class NumberapiComponent implements OnInit {
  constructor(private apiService: NumberapisvcService) {
  }
  ngOnInit(): void {
    this.apiService.getFactFor(10)
      .subscribe(d => console.log(d.text))
    this.apiService.getFactFor(20)
      .subscribe(d => console.log(d.text))
    console.log("End of NgOnInit")
  }
}
