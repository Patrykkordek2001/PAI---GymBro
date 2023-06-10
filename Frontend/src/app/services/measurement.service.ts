import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Measurement } from '../models/measurement.model';

@Injectable({
  providedIn: 'root'
})
export class MeasurementService {
  constructor(private httpClient: HttpClient) { }



  addMeasurement(measurementData: Measurement): Observable<any> {
    return this.httpClient.post<any>('http://localhost:7131/api/Measurement/AddMeasurement', measurementData);
  }

  getAllMeasurements(): Observable<Measurement[]> {
    return this.httpClient.get<Measurement[]>('http://localhost:7131/api/Measurement/GetAllMeasurements');
  }


}
