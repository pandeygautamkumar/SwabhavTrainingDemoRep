import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'sw-login',
  templateUrl: './login.component.html'
})
export class LoginComponent {
  formLogin: FormGroup
  constructor() {
    this.formLogin = new FormGroup({
      'userName': new FormControl('Ashish', Validators.required),
      'userPassword': new FormControl('', Validators.required)
    })
  }
  submitHandler() {
    alert("...Success....")
  }
}
