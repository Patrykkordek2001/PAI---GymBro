import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WorkoutsComponent } from './containers/workouts.component';



@NgModule({
  declarations: [WorkoutsComponent],
  imports: [
    CommonModule
  ],
  providers:[WorkoutsComponent]
})
export class WorkoutsModule { }
