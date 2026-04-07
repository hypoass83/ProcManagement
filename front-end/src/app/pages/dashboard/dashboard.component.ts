import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  templateUrl: './dashboard.component.html'
})
export class DashboardComponent {

  userId: string = '';

  constructor(
    private router: Router,
    private authService: AuthService
  ) {
    this.userId = localStorage.getItem('userId') || '';
  }

  logout() {
    this.authService.logout();
    this.router.navigate(['/']);
  }
}