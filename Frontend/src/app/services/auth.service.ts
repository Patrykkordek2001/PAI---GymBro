import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Login } from '../models/login.model';
import { Register } from '../models/register.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService  {

  isLoggedIn: boolean = false;

  constructor(private httpClient: HttpClient) { }

  updateLoggedIn(value: boolean): void {
    this.isLoggedIn = value;
  }

  loginToSystem(loginData: Login): Observable<any> {
    return this.httpClient.post<any>('http://localhost:7131/api/Auth/Login', loginData);
  }

  registerToTheSystem(registerData: Register): Observable<any> {
    return this.httpClient.post<number>('http://localhost:7131/api/Auth/Register', registerData);
  }

}