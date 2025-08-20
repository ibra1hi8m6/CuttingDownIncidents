import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {  FormsModule, ReactiveFormsModule,  } from '@angular/forms';
import { HeaderComponent } from '../header/header.component';
import { Router } from '@angular/router';
import { AuthService, LoginRequest } from '../../services/auth.service';

import { HttpClientModule } from '@angular/common/http';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule,HeaderComponent,
    HttpClientModule,],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
 loginData: LoginRequest = {
    name: '',
    password: ''
  };

  message: string | null = null;
  loading = false;

  constructor(private router: Router,private authService: AuthService) {}
  onLogin() {
    this.authService.login(this.loginData).subscribe({
      next: (response) => {
        console.log("Login successful", response);

        // ✅ Save token (if exists)
        if (response.token) {
          localStorage.setItem("authToken", response.token);
        }

        // ✅ Redirect to "shared/search" after login
        this.router.navigate(['/shared']);
      },
      error: (err) => {
        console.error("Login failed", err);
        alert("Invalid credentials");
      }
    });
  }
  skip() {
    this.router.navigate(['/shared']); // redirect to SharedComponent
  }
}
