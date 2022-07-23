import { IAuthor } from "../authors/author";

export interface IContact {
  contactId: number;
  email: string;
  phone: string;
  authorId: number;
  author: IAuthor;
}
