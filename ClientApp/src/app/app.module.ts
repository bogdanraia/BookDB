import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BooksComponent } from './books/books.component';
import { AuthorsComponent } from './authors/authors.component';
import { GenresComponent } from './genres/genres.component';
import { DomainsComponent } from './domains/domains.component';

import { AuthorsService } from './authors/authors.service';
import { BooksService } from './books/books.service';
import { BookTypesService } from './bookTypes/bookTypes.service';
import { ContactsService } from './contacts/contacts.service';
import { DomainsService } from './domains/domains.service';
import { GenresService } from './genres/genres.service';
import { LocationsService } from './locations/locations.service';
import { PublishersService } from './publishers/publishers.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    BooksComponent,
    AuthorsComponent,
    GenresComponent,
    DomainsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'book', component: BooksComponent },
      { path: 'author', component: AuthorsComponent },
      { path: 'genre', component: GenresComponent },
      { path: 'domain', component: DomainsComponent }
    ])
  ],
  providers: [
    AuthorsService,
    BooksService,
    BookTypesService,
    ContactsService,
    DomainsService,
    GenresService,
    LocationsService,
    PublishersService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
