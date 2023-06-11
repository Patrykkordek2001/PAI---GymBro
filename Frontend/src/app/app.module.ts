import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalendarComponent } from './modules/calendar/calendar.component';
import { WorkoutsComponent } from './modules/workouts/workouts.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginPageModule } from './modules/login/login-page.module';
import { HttpClientModule } from '@angular/common/http';
import { RegisterPageModule } from './modules/register/register-page.module';
import { AddMeasurementModule } from './modules/add-measurement/add-measurement.module';
import { MeasurementsModule } from './modules/measurements/measurements.module';
import { AddWorkoutComponent } from './modules/add-workout/containers/add-workout.component';

@NgModule({
  declarations: [
    AppComponent,
    CalendarComponent,
    AddWorkoutComponent,
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
    AddMeasurementModule,
    MeasurementsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
