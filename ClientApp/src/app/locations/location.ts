import { IPublisher } from "../publishers/publisher";

export interface ILocation {
  locationId: number;
  city: string;
  publisherId: number;
  publisher: IPublisher;
}
