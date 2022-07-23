import { IBook } from "../books/book";
import { ILocation } from "../locations/location";

export interface IPublisher {
  publisherId: number;
  name: string;
  locations: ILocation[];
  books: IBook[];
}
