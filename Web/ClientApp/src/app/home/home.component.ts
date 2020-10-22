import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { HomeService } from './home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private homeservice: HomeService) { }

  submit(form: NgForm) {

    var user = new User();
    user.email = form.value.email;
    user.password = form.value.password;

    this.homeservice.post(user);
  }

}

export class User {

  email: string;
  password: string;
}
