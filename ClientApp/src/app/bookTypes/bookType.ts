import { IBook } from "../books/book";

export interface IBookType {
  bookTypeId: number;
  type: string;
  books: IBook[];
}
