import { Component, OnInit } from '@angular/core';
import { MoviesAndTvShows } from '../_services/moviesAndTvShows.service';
import { MovieAndTvShow } from '../_shared/movieAndTvShow.model';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  movieTvShowList:MovieAndTvShow[]=[];
  Title="";
  Type="";
  p:number=1;
  constructor(public service:MoviesAndTvShows) { }

  ngOnInit() {
    this.allMoviesAndTvShows(this.Title,this.Type);
  }
  allMoviesAndTvShows(Title:string,Type:string){
    this.service.getMoviesAndTvShows(this.Title,this.Type).subscribe(data=>{
      this.movieTvShowList=data;
    })
  }
  Search(){
    this.allMoviesAndTvShows(this.Title,this.Type);
  }

}
