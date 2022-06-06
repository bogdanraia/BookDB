import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IAuthor } from './author';
import { Observable } from 'rxjs';

@Injectable()
export class AuthorsService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getAuthors(): Observable<IAuthor[]> {
    return this._http.get<IAuthor[]>(this._baseUrl + 'author');
  }
}
