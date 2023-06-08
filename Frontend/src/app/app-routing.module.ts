import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalendarComponent } from './modules/calendar/calendar.component';
import { AddWorkoutComponent } from './modules/add-workout/add-workout.component';
import { AddMeasurementComponent } from './modules/add-measurement/add-measurement.component';
import { WorkoutsComponent } from './modules/workouts/workouts.component';
import { MeasurementsComponent } from './modules/measurements/measurements.component';
import { LoginPageComponent } from './modules/login/containers/login-page.component';
import { RegisterPageComponent } from './modules/register/containers/register-page.component';

const routes: Routes = [
  {path: 'login', component: LoginPageComponent},
  {path: 'calendar', component: CalendarComponent},
  {path: 'add-workout', component: AddWorkoutComponent},
  {path: 'add-measurement', component: AddMeasurementComponent},
  {path: 'workouts', component: WorkoutsComponent},
  {path: 'measurements', component: MeasurementsComponent},
  {path: 'register', component: RegisterPageComponent},

];





@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
