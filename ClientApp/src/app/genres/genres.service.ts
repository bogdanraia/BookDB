import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IGenre } from './genre';
import { Observable } from 'rxjs';

@Injectable()
export class GenresService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getGenres(): Observable<IGenre[]> {
    return this._http.get<IGenre[]>(this._baseUrl + 'genre');
  }
}
