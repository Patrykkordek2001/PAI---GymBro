import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddMeasurementComponent } from './containers/add-measurement.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [AddMeasurementComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  exports: [AddMeasurementComponent],
})
export class AddMeasurementModule { }
