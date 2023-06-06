import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent {
  loginForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private router: Router) {
    this.loginForm = this.formBuilder.group({
      login: ["", Validators.required],
      password: ["", Validators.required],
    });
  }



 login(): void {
 //   this.authService.loginToSystem(this.form.value).subscribe(response => {
 //     localStorage.setItem('tokenZTPAI', response.token);
  //    this.authService.updateLoggedIn(true);
   //   this.router.navigateByUrl('/');
  //  });
  }

  goToRegisterPage(): void{
    this.router.navigateByUrl('/');
    this.router.navigateByUrl('/register');
  }
}