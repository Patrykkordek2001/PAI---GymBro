import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalendarComponent } from './modules/calendar/calendar.component';
import { WorkoutsComponent } from './modules/workouts/workouts.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginPageModule } from './modules/login/login-page.module';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RegisterPageModule } from './modules/register/register-page.module';
import { AddMeasurementModule } from './modules/add-measurement/add-measurement.module';
import { MeasurementsModule } from './modules/measurements/measurements.module';
import { AddWorkoutModule } from './modules/add-workout/add-workout.module';
import { TokenInterceptor } from './interceptor/token.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    CalendarComponent,
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
    MeasurementsModule,
    AddWorkoutModule
    
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: TokenInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
