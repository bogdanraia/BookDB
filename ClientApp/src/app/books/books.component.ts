import { Component } from '@angular/core';
import { IBook } from './book';
import { BooksService } from './books.service';
import { Injectable, Inject } from '@angular/core';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html'
})

@Injectable()
export class BooksComponent {
  public books: IBook[] = [];

  constructor(private _bookService: BooksService) { }

  ngOnInit() {
    this._bookService.getBooks().subscribe(
      (result) => {
        this.books = result;
      },
      (error) => {
        console.error(error);
      });
  }
}
