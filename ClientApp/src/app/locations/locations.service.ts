import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ILocation } from './location';
import { Observable } from 'rxjs';

@Injectable()
export class LocationsService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getLocations(): Observable<ILocation[]> {
    return this._http.get<ILocation[]>(this._baseUrl + 'location');
  }
}
