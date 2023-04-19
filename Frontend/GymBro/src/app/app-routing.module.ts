import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './modules/home-page/home-page.component';
import { CalendarComponent } from './modules/calendar/calendar.component';
import { AddWorkoutComponent } from './modules/add-workout/add-workout.component';
import { AddMeasurementComponent } from './modules/add-measurement/add-measurement.component';
import { WorkoutsComponent } from './modules/workouts/workouts.component';
import { MeasurementsComponent } from './modules/measurements/measurements.component';

const routes: Routes = [
  {path: 'home-page', component: HomePageComponent},
  {path: 'calendar', component: CalendarComponent},
  {path: 'add-workout', component: AddWorkoutComponent},
  {path: 'add-measurement', component: AddMeasurementComponent},
  {path: 'workouts', component: WorkoutsComponent},
  {path: 'measurements', component: MeasurementsComponent},

];





@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
