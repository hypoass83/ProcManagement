import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private apiUrl = 'http://localhost:5003/api/auth/login';

  constructor(private http: HttpClient) {}

  login(userId: string, password: string) {
    return this.http.post<any>(this.apiUrl, {
      userId,
      password
    });
  }

  setSession(userId: string) {
    localStorage.setItem('isLoggedIn', 'true');
    localStorage.setItem('userId', userId);
  }

  logout() {
    localStorage.clear();
  }

  isLoggedIn(): boolean {
    return localStorage.getItem('isLoggedIn') === 'true';
  }
}