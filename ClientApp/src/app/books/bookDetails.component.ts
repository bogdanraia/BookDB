import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IBook } from './book';
import { BooksComponent } from './books.component';

@Component({
  selector: 'bookDetails',
  templateUrl: './bookDetails.component.html'
})

export class BooksDetailsComponent implements OnInit {

  book: IBook | undefined;

  constructor(private route: ActivatedRoute, private _booksComponent: BooksComponent) { }

  ngOnInit() {
    // First get the product id from the current route.
    const routeParams = this.route.snapshot.paramMap;
    const bookIdFromRoute = Number(routeParams.get('id'));

    // Find the product that correspond with the id provided in route.
    this.book = this._booksComponent.books.find(book => book.bookId === bookIdFromRoute);
  }

}

