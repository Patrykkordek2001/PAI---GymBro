import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MeasurementsComponent } from './containers/measurements.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [MeasurementsComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  exports: [MeasurementsComponent]
})
export class MeasurementsModule { }
