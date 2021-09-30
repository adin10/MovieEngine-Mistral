import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import{ReactiveFormsModule} from '@angular/forms';
import{NgxPaginationModule} from 'ngx-pagination';
import{Ng2OrderModule} from 'ng2-order-pipe'
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { MovieComponent } from './movie/movie.component';
import { UploadComponent } from './upload/upload.component';
import { AddMovieTvShowComponent } from './add-movie-tv-show/add-movie-tv-show.component';
import { RatingComponent } from './rating/rating.component';
import { AddRatingComponent } from './add-rating/add-rating.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MovieComponent,
    UploadComponent,
    AddMovieTvShowComponent,
    RatingComponent,
    AddRatingComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    NgxPaginationModule,
    FormsModule,
    Ng2OrderModule,
    ReactiveFormsModule,
   
    RouterModule.forRoot([
      { path: '', component: MovieComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      {path:"movie",component:MovieComponent},
      {path:"addMovie",component:AddMovieTvShowComponent},
      {path:"rating",component:RatingComponent},
      {path:"addRating/:id",component:AddRatingComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
