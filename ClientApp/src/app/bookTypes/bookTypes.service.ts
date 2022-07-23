import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IBookType } from './bookType';
import { Observable } from 'rxjs';

@Injectable()
export class BookTypesService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getBookTypes(): Observable<IBookType[]> {
    return this._http.get<IBookType[]>(this._baseUrl + 'bookType');
  }
}
