import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MeasurementPreview } from 'src/app/models/measurementPreview.model';
import { MeasurementService } from 'src/app/services/measurement.service';

@Component({
  selector: 'app-measurements',
  templateUrl: './measurements.component.html',
  styleUrls: ['./measurements.component.css'],
})
export class MeasurementsComponent implements OnInit {
  measurements: MeasurementPreview[] = [];

  constructor(private measurementService: MeasurementService,
    private router: Router) {}
  ngOnInit(): void {
    this.measurementService.getAllMeasurements().subscribe((x) => {
      console.log(x);
      this.measurements = x;
    });
  }

  deleteMeasurement(measurementId: string) {
    this.measurementService
      .deleteMeasurement(measurementId)
      .subscribe((res) => location.reload());
  }
  addMeasurement():void{
    this.router.navigate(['/add-measurement']);
  }
  goToWorkouts():void{
    this.router.navigate(['/workouts']);
  }
}
