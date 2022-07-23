import { IAuthor } from "../authors/author";
import { IBookType } from "../bookTypes/bookType";
import { IDomain } from "../domains/domain";
import { IGenre } from "../genres/genre";
import { IPublisher } from "../publishers/publisher";

export interface IBook {
  bookId: number;
  title: string;
  pageCount: number;
  authorId: number;
  author: IAuthor;
  publisherId: number;
  publisher: IPublisher;
  genres: IGenre[];
  domains: IDomain[];
  bookTypes: IBookType[];
}
