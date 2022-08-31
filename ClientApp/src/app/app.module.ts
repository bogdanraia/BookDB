import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BooksComponent } from './books/books.component';
import { AuthorsComponent } from './authors/authors.component';
import { GenresComponent } from './genres/genres.component';
import { BooksDetailsComponent } from './books/bookDetails.component';
import { AuthorsService } from './authors/authors.service';
import { BooksService } from './books/books.service';
import { GenresService } from './genres/genres.service';
import { LocationsService } from './locations/locations.service';
import { PublishersService } from './publishers/publishers.service';
import { ReactiveformComponent } from './books/reactiveform.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    BooksComponent,
    BooksDetailsComponent,
    AuthorsComponent,
    GenresComponent,
    ReactiveformComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'book', component: BooksComponent },
      { path: 'book/:id', component: BooksDetailsComponent},
      { path: 'author', component: AuthorsComponent },
      { path: 'genre', component: GenresComponent },
    ])
  ],
  providers: [
    AuthorsService,
    BooksService,
    BooksComponent,
    GenresService,
    LocationsService,
    PublishersService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
