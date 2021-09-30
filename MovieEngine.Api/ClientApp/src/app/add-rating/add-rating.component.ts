import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
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

  id : number;
  title : string = "";
  constructor(public router:Router,public moviesService:MoviesAndTvShows,
     public service:RatingService,public fb:FormBuilder,
     private route : ActivatedRoute) { }

  ngOnInit() {
    this.allMoviesAndTvShows("","");

    this.route.params.subscribe(
      (params : Params) => {

        this.id = +params['id'];
      

        if(!Number.isNaN(this.id)  &&  this.id != 0 ){
          this.moviesService.getMovieTvShowById(this.id).subscribe(
            res =>{
              this.title = res.title;
            }
          );
        }
      

      }
    );

    this.forma=this.fb.group({
      // MovieAndTvShowID:["",[Validators.required]],
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
    let podaci=new RatingInsertRequest(this.id,+this.forma.get('RatingValue').value);
    this.service.addRating(podaci).subscribe(data=>{
      this.getAllRatings();
    })
    this.forma.reset();
    this.router.navigate(["/rating"]);
  }

}
