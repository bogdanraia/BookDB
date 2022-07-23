import { IBook } from "../books/book";

export interface IDomain {
  domainId: number;
  name: string;
  books: IBook[];
}
