import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { RegisterPageComponent } from './containers/register-page.component';



@NgModule({
  declarations: [RegisterPageComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,

  ],
  exports: [RegisterPageComponent],
})
export class RegisterPageModule { }
