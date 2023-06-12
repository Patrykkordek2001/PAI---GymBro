import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginPageComponent } from './containers/login-page.component';
import { ToastrModule } from 'ngx-toastr';



@NgModule({
  declarations: [LoginPageComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    ToastrModule

  ],
  exports: [LoginPageComponent],
})
export class LoginPageModule { }
