import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { User } from './home.component';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  uri = "api/login";


  constructor(private http: HttpClient, private router: Router) { }

  login(user:User) {
    this.http.post(this.uri, user)
      .subscribe((resp: any) => {

        this.router.navigate(['adminpanel']);
        console.log(resp);
        localStorage.setItem('auth_token', resp);
      });
  }
}
