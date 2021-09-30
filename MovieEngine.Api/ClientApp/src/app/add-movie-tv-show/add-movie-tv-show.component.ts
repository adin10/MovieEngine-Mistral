import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MoviesAndTvShows } from '../_services/moviesAndTvShows.service';
import { MovieAndTvShow } from '../_shared/movieAndTvShow.model';
import { MovieAndTvShowInsertRequest } from '../_shared/requests/movieAndTvShowInsertRequest.model';

@Component({
  selector: 'app-add-movie-tv-show',
  templateUrl: './add-movie-tv-show.component.html',
  styleUrls: ['./add-movie-tv-show.component.css']
})
export class AddMovieTvShowComponent implements OnInit {

  constructor(public service:MoviesAndTvShows,public fb:FormBuilder,public router:Router) { }
  public response: {
    dbPath: '',
    fileName: '',
    fullPath: ''
  };
  forma:FormGroup;
  movieTvShowList:MovieAndTvShow[]=[];

  ngOnInit() {
    this.forma=this.fb.group({
      Title:["",[Validators.required]],
      Type:[""],
      Description:[""],
      ReleaseDate:[""]
    })
  }
  allMoviesAndTvShows(Title:string,Type:string){
    this.service.getMoviesAndTvShows("","").subscribe(data=>{
      this.movieTvShowList=data;
    })
  }

  onSubmit(){
    let podaci=new MovieAndTvShowInsertRequest(this.forma.get('Title').value,
      this.forma.get('Type').value,this.forma.get('Description').value,this.forma.get('ReleaseDate').value,
      this.response.fileName,this.response.dbPath
      )
      this.service.addMovieAndTvShow(podaci).subscribe(data=>{
          this.allMoviesAndTvShows("","");
      })
      this.forma.reset();
      this.router.navigate(["/movie"]);
  }
  public uploadFinished = (event) =>{
    this.response=event;
  }
  public createImgPath = () =>{
    if(this.response!=null)
    return '${environment.apiUrl}${this.response.dbPath}';
  }
}

