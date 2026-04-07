import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './login.component.html'
})
export class LoginComponent {

  userId: string = '';
  
  password: string = '';
  errorMessage: string = '';

  constructor(
    private authService: AuthService,
    private router: Router
  ) {}

  login() {
    this.authService.login(this.userId, this.password).subscribe({
      next: () => {
        this.authService.setSession(this.userId);
        this.router.navigate(['/dashboard']);
      },
      error: (err) => {
       console.log(err); // 👈 DEBUG

      // ✅ GET message from backend
      if (err.status === 401 && err.error) {
        this.errorMessage = err.error.message || 'Invalid credentials';
      } else {
        this.errorMessage = 'Server error. Try again.';
      }
      }
    });
  }
}