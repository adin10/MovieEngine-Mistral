import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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

  n : number = 3;
  constructor(public service:MoviesAndTvShows,  private router : Router) { }

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

  showMore(){
    this.n += this.n;

  }

  getByType(Type : string){
    this.service.getMoviesAndTvShows("",Type).subscribe(data=>{
      this.movieTvShowList=data;
    })
  }
  navi(id : number){
    this.router.navigate(["/addRating/",id]);
  }
  public createImgPath = (serverPath: string) => {
    return `https://localhost:5001/${serverPath}`;
  }


}
