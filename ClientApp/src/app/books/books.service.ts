import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IBook } from './book';
import { Observable } from 'rxjs';

@Injectable()
export class BooksService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getBooks(): Observable<IBook[]> {
    return this._http.get<IBook[]>(this._baseUrl + 'book');
  }
}
