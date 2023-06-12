import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { WorkoutPreview } from 'src/app/models/workoutPreview.model';
import { WorkoutService } from 'src/app/services/workout.service';

@Component({
  selector: 'app-workouts',
  templateUrl: './workouts.component.html',
  styleUrls: ['./workouts.component.css']
})
export class WorkoutsComponent {
  workouts: WorkoutPreview[] =[];

  constructor(
    private workoutService: WorkoutService
  ) {
  }
  ngOnInit(): void {
    this.workoutService.getAllWorkouts().subscribe(x => {
      console.log(x);
      this.workouts = x;
    });
  }

  deleteWorkout(measurementId:string){
    this.workoutService.deleteWorkout(measurementId).subscribe(res =>location.reload());
  }
}

