import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalendarComponent } from './modules/calendar/calendar.component';
import { AddWorkoutComponent } from './modules/add-workout/add-workout.component';
import { AddMeasurementComponent } from './modules/add-measurement/add-measurement.component';
import { MeasurementsComponent } from './modules/measurements/measurements.component';
import { WorkoutsComponent } from './modules/workouts/workouts.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginPageModule } from './modules/login/login-page.module';
import { HttpClientModule } from '@angular/common/http';
import { RegisterPageModule } from './modules/register/register-page.module';

@NgModule({
  declarations: [
    AppComponent,
    CalendarComponent,
    AddWorkoutComponent,
    AddMeasurementComponent,
    MeasurementsComponent,
    WorkoutsComponent,
     
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatInputModule,
    LoginPageModule,
    HttpClientModule,
    RegisterPageModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
