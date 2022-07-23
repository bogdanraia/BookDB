import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { IAuthor } from './author';
import { AuthorsService } from './authors.service';

@Component({
  selector: 'app-authors',
  templateUrl: './authors.component.html'
})

export class AuthorsComponent implements OnInit {
  public authors: IAuthor[] = [];

  constructor(private _authorService: AuthorsService) {  }

  ngOnInit() {
    this._authorService.getAuthors().subscribe(
      (result) => {
        this.authors = result;
      },
      (error) => {
        console.error(error);
      });
  }
}
