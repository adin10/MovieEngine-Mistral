import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MoviesAndTvShows } from '../_services/moviesAndTvShows.service';
import { RatingService } from '../_services/rating.service';
import { MovieAndTvShow } from '../_shared/movieAndTvShow.model';
import { Rating } from '../_shared/rating.model';
import { RatingInsertRequest } from '../_shared/requests/ratingInsertRequest.model';

@Component({
  selector: 'app-add-rating',
  templateUrl: './add-rating.component.html',
  styleUrls: ['./add-rating.component.css']
})
export class AddRatingComponent implements OnInit {

  ratingList:Rating[]=[];
  movieTvShowList:MovieAndTvShow[]=[];
  forma:FormGroup;
  constructor(public router:Router,public moviesService:MoviesAndTvShows, public service:RatingService,public fb:FormBuilder) { }

  ngOnInit() {
    this.allMoviesAndTvShows("","");
    this.forma=this.fb.group({
      MovieAndTvShowID:["",[Validators.required]],
      RatingValue:["",[Validators.required]]
    })
  }

  getAllRatings(){
    this.service.getRatings("",null).subscribe(data=>{
      this.ratingList=data;
    })
  }


  allMoviesAndTvShows(Title:string,Type:string){
    this.moviesService.getMoviesAndTvShows("","").subscribe(data=>{
      this.movieTvShowList=data;
    })
  }
  onSubmit(){
    let podaci=new RatingInsertRequest(this.forma.get('MovieAndTvShowID').value,+this.forma.get('RatingValue').value);
    this.service.addRating(podaci).subscribe(data=>{
      this.getAllRatings();
    })
    this.forma.reset();
    this.router.navigate(["/rating"]);
  }

}
