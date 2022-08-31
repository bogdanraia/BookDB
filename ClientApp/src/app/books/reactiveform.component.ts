import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { NgForm } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { IBook } from './book';
import { IGenre } from '../genres/genre';
import { IPublisher } from '../publishers/publisher';
import { IAuthor } from '../authors/author';
import { BooksService } from '../books/books.service';

@Component({
  selector: 'reactiveform',
  templateUrl: './reactiveform.component.html',
  styleUrls: ['./reactiveform.component.css']
})
export class ReactiveformComponent implements OnInit {
  Form = new FormGroup({
    title: new FormControl('title'),
    nrPages: new FormControl('nrPages'),
    author: new FormControl('author'),
    publisher: new FormControl('publisher'),
  });
  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }

  ngOnInit(): void {
  }

  addBook(book: IBook) {
    console.log(book);
    return this._http.post<IBook>(this._baseUrl + 'book/add', book);
  }

  onSubmit() {
    var book: IBook = {
      bookId: 1, genres: [], publisher: {} as IPublisher, publisherId: 1, author: {} as IAuthor, authorId: 1, title: this.Form.value.title, pageCount: this.Form.value.nrPages
    };
    this.addBook(book).subscribe(
      (result) => {
      },
      (error) => {
        console.error(error);
      });
  }
  
}
