import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from './auth.service';
import { User } from './home.component';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private httpClient: HttpClient, private as: AuthService) { }

  post(user: User) {


    this.as.login(user);
    
  }
}
