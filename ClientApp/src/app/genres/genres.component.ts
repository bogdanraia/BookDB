import { Component } from '@angular/core';
import { IGenre } from './genre';
import { GenresService } from './genres.service';

@Component({
  selector: 'app-genres',
  templateUrl: './genres.component.html'
})

export class GenresComponent {
  public genres: IGenre[] = [];

  constructor(private _genreService: GenresService) { }

  ngOnInit() {
    this._genreService.getGenres().subscribe(
      (result) => {
        this.genres = result;
      },
      (error) => {
        console.error(error);
      });
  }
}
