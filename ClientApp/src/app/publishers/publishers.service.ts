import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPublisher } from './publisher';
import { Observable } from 'rxjs';

@Injectable()
export class PublishersService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getPublishers(): Observable<IPublisher[]> {
    return this._http.get<IPublisher[]>(this._baseUrl + 'publisher');
  }
}
