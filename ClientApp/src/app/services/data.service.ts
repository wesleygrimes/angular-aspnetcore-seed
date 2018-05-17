import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { WeatherForecast } from '../models';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  constructor(
    @Inject('BASE_URL') private baseUrl: string,
    private httpClient: HttpClient
  ) {}

  getWeatherData(): Observable<WeatherForecast[]> {
    return this.httpClient.get<WeatherForecast[]>(
      this.baseUrl + 'api/SampleData/WeatherForecasts'
    );
  }
}
