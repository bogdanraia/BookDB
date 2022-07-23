import { IBook } from "../books/book";

export interface IGenre {
  genreId: number;
  name: string;
  books: IBook[];
}
