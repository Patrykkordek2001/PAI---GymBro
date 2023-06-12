import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { MeasurementService } from 'src/app/services/measurement.service';

@Component({
  selector: 'app-add-measurement',
  templateUrl: './add-measurement.component.html',
  styleUrls: ['./add-measurement.component.css'],
})
export class AddMeasurementComponent {
  measurementForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private measurementService: MeasurementService
  ) {
    this.measurementForm = this.formBuilder.group({
      measurementDate: [  Date.now, Validators.required],
      weight: ['', Validators.required],
      arms: ['', Validators.required],
      chest: ['', Validators.required],
      waist: ['', Validators.required],
      hips: ['', Validators.required],
      thighs: ['', Validators.required],
    });
  }

  submit(): void {
    console.log(this.measurementForm.value);
    this.measurementService.addMeasurement(this.measurementForm.value).subscribe((response) => {
      this.router.navigate(['/measurements']);
    });
  }

  reset(): void {
    this.measurementForm.reset();
    this.measurementForm.markAsPristine();
    this.measurementForm.markAsUntouched();
  }

  back(): void {
    this.reset();
    this.router.navigate(['/measurements']);
  }
}
