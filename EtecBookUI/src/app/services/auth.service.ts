import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private baseURl:string ="http://localhost:5024/api/Account/";
  constructor(private http: HttpClient) { }

  login(loginObj: any){
    return this.http.post<any>(`${this.baseURl}authenticate`, loginObj);
  }

  logout(){

  }

  register(){

  }
}
