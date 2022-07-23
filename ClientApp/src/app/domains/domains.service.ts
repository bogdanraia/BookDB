import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IDomain } from './domain';
import { Observable } from 'rxjs';

@Injectable()
export class DomainsService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getDomains(): Observable<IDomain[]> {
    return this._http.get<IDomain[]>(this._baseUrl + 'domain');
  }
}
