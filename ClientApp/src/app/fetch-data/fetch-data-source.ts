import { DataSource } from '@angular/cdk/table';
import { Observable } from 'rxjs';

import { WeatherForecast } from '../models';

export class FetchDataSource extends DataSource<WeatherForecast> {
  constructor(private data: Observable<WeatherForecast[]>) {
    super();
  }

  connect(): Observable<WeatherForecast[]> {
    return this.data;
  }
  disconnect(): void {}
}
