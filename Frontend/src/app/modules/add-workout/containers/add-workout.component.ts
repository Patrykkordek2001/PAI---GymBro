import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { WorkoutService } from 'src/app/services/workout.service';

@Component({
  selector: 'app-add-workout',
  templateUrl: './add-workout.component.html',
  styleUrls: ['./add-workout.component.css']
})
export class AddWorkoutComponent {
  workoutForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private workoutservice: WorkoutService
  ) {
    this.workoutForm = this.formBuilder.group({
      workoutDate: [  Date.now, Validators.required],
      title: ['', Validators.required],
      description: ['', Validators.required],
    });
  }

  submit(): void {
    console.log(this.workoutForm.value);
    this.workoutservice.addWorkout(this.workoutForm.value).subscribe((response) => {
      this.router.navigateByUrl('/workouts');
    });
  }

  reset(): void {
    this.workoutForm.reset();
    this.workoutForm.markAsPristine();
    this.workoutForm.markAsUntouched();
  }
}
