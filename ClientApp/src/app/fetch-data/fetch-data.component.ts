import { Component, OnInit } from '@angular/core';

import { DataService } from '../services/data.service';
import { FetchDataSource } from './fetch-data-source';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  styleUrls: ['./fetch-data.component.css']
})
export class FetchDataComponent implements OnInit {
  dataSource: FetchDataSource;

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = [
    'dateFormatted',
    'temperatureC',
    'temperatureF',
    'summary'
  ];

  constructor(private dataService: DataService) {}

  ngOnInit() {
    this.dataSource = new FetchDataSource(this.dataService.getWeatherData());
  }
}
