import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RegisterPageModule } from './modules/register/register-page.module';
import { AddMeasurementModule } from './modules/add-measurement/add-measurement.module';
import { MeasurementsModule } from './modules/measurements/measurements.module';
import { AddWorkoutModule } from './modules/add-workout/add-workout.module';
import { TokenInterceptor } from './interceptor/token.interceptor';
import { ToastrModule } from 'ngx-toastr';
import { WorkoutsModule } from './modules/workouts/workouts.module';
import { LoginPageModule } from './modules/login/login-page.module';

@NgModule({
  declarations: [
    AppComponent,
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatInputModule,
    HttpClientModule,
    RegisterPageModule,
    AddMeasurementModule,
    MeasurementsModule,
    AddWorkoutModule,
    ToastrModule.forRoot(),
    WorkoutsModule,
    LoginPageModule
    
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: TokenInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
