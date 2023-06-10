import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrls: ['./register-page.component.css']
})
export class RegisterPageComponent {
  registerForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private router: Router, private authService: AuthService) {
    this.registerForm = this.formBuilder.group({
      name: ["", Validators.required],
      email: ["", Validators.required],
      username: ["", Validators.required],
      password: ["", Validators.required],
    });
  }



 register(): void {
  console.log(this.registerForm.value);
   this.authService.register(this.registerForm.value).subscribe(response => {
    console.log(response);
     this.authService.updateLoggedIn(true);
      this.router.navigateByUrl('/login');
    });
 }

  goToLoginPage(): void{
    this.router.navigateByUrl('/login');
  }
}