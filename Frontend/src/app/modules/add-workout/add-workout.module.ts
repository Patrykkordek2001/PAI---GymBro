import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { AddWorkoutComponent } from './containers/add-workout.component';



@NgModule({
  declarations: [AddWorkoutComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  providers:[AddWorkoutComponent]
})
export class AddWorkoutModule { }
