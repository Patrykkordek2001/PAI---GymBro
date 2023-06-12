import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Measurement } from '../models/measurement.model';
import { MeasurementPreview } from '../models/measurementPreview.model';

@Injectable({
  providedIn: 'root'
})
export class MeasurementService {
  constructor(private httpClient: HttpClient) { }

  addMeasurement(measurementData: Measurement): Observable<any> {
    return this.httpClient.post<any>('http://localhost:7131/api/Measurement/AddMeasurement', measurementData);
  }

  getAllMeasurements(): Observable<MeasurementPreview[]> {
    return this.httpClient.get<MeasurementPreview[]>('http://localhost:7131/api/Measurement/GetAllMeasurements');
  }

  deleteMeasurement(measurementId: string): Observable<any> {
    return this.httpClient.delete<any>('http://localhost:7131/api/Measurement/DeleteMeasurement/'+ measurementId);
  }
  
}
