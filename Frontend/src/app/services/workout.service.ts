import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Workout } from '../models/workout.model';
import { Observable } from 'rxjs';
import { WorkoutPreview } from '../models/workoutPreview.model';

@Injectable({
  providedIn: 'root',
})
export class WorkoutService {
  constructor(private httpClient: HttpClient) {}

  addWorkout(workoutData: Workout): Observable<any> {
    console.log(workoutData);
    return this.httpClient.post<any>(
      'http://localhost:7131/api/Workout/AddWorkout',
      workoutData
    );
  }

  getAllWorkouts(): Observable<WorkoutPreview[]> {
    return this.httpClient.get<WorkoutPreview[]>(
      'http://localhost:7131/api/Workout/GetAllWorkouts'
    );
  }

  deleteWorkout(workoutId: string): Observable<any> {
    return this.httpClient.delete<any>(
      'http://localhost:7131/api/Workout/DeleteWorkout/' + workoutId
    );
  }
}
