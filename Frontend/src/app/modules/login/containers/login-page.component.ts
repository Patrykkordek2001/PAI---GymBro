import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent {
  loginForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private router: Router, private authService: AuthService) {
    this.loginForm = this.formBuilder.group({
      username: ["", Validators.required],
      password: ["", Validators.required],
    });
  }



 login(): void {
  console.log(this.loginForm.value);
   this.authService.loginToSystem(this.loginForm.value).subscribe(response => {

      localStorage.setItem('tokenJWT', response.token);
     this.authService.updateLoggedIn(true);
      this.router.navigateByUrl('/add-workout');
    });
 }

  goToRegisterPage(): void{
    this.router.navigateByUrl('/register');
  }
}