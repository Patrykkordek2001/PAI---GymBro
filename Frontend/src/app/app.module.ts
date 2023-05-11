import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalendarComponent } from './modules/calendar/calendar.component';
import { AddWorkoutComponent } from './modules/add-workout/add-workout.component';
import { AddMeasurementComponent } from './modules/add-measurement/add-measurement.component';
import { MeasurementsComponent } from './modules/measurements/measurements.component';
import { WorkoutsComponent } from './modules/workouts/workouts.component';
import { HomePageComponent } from './modules/home-page/home-page.component';
import { LoginOrRegisterComponent } from './modules/login-or-register/login-or-register.component';

@NgModule({
  declarations: [
    AppComponent,
    CalendarComponent,
    AddWorkoutComponent,
    AddMeasurementComponent,
    MeasurementsComponent,
    WorkoutsComponent,
    HomePageComponent,
    LoginOrRegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
