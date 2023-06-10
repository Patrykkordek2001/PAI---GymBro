import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Measurement } from 'src/app/models/measurement.model';
import { MeasurementService } from 'src/app/services/measurement.service';


@Component({
  selector: 'app-measurements',
  templateUrl: './measurements.component.html',
  styleUrls: ['./measurements.component.css']
})
export class MeasurementsComponent implements OnInit{
  
  measurementForm: FormGroup;

  measurements: Measurement[] =[];

  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private measurementService: MeasurementService
  ) {
    this.measurementForm = this.formBuilder.group({
      date: [  Date.now, Validators.required],
      weight: ['', Validators.required],
      arms: ['', Validators.required],
      chest: ['', Validators.required],
      waist: ['', Validators.required],
      hips: ['', Validators.required],
      thighs: ['', Validators.required],
    });
  }
  ngOnInit(): void {
    this.measurementService.getAllMeasurements().subscribe(x => {
      console.log(this.measurements);
      x = this.measurements
    });
  }

  submit(): void {
    console.log(this.measurementForm.value);
    this.measurementService.addMeasurement(this.measurementForm.value).subscribe((response) => {
      this.router.navigateByUrl('/measurement');
    });
  }

  reset(): void {
    this.measurementForm.reset();
    this.measurementForm.markAsPristine();
    this.measurementForm.markAsUntouched();
  }

}
