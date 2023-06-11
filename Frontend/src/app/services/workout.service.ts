import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Workout } from '../models/workout.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WorkoutService {

  constructor(private httpClient: HttpClient) { }

  addWorkout(workoutData: Workout): Observable<any> {
    console.log(workoutData);
    return this.httpClient.post<any>('http://localhost:7131/api/Workout/AddWorkout', workoutData);
  }

  getAllWorkouts(): Observable<Workout[]> {
    return this.httpClient.get<Workout[]>('http://localhost:7131/api/Workout/GetAllWorkouts');
  }
}
