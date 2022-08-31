import { IAuthor } from "../authors/author";
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
}


