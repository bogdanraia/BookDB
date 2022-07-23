import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IContact } from './contact';
import { Observable } from 'rxjs';

@Injectable()
export class ContactsService {
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  getContacts(): Observable<IContact[]> {
    return this._http.get<IContact[]>(this._baseUrl + 'contact');
  }
}
