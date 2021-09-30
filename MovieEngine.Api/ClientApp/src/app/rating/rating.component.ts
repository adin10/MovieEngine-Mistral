import { Component, OnInit } from '@angular/core';
import { RatingService } from '../_services/rating.service';
import { Rating } from '../_shared/rating.model';

@Component({
  selector: 'app-rating',
  templateUrl: './rating.component.html',
  styleUrls: ['./rating.component.css']
})
export class RatingComponent implements OnInit {

  ratingList:Rating[]=[];
  Title:string="";
  RatingValue:number=null;
  constructor(public service:RatingService) { }

  ngOnInit() {
    this.getAllRatings(this.Title,this.RatingValue);
  }

  getAllRatings(Title:string,ratingValue:number){
    this.service.getRatings(this.Title,this.RatingValue).subscribe(data=>{
      this.ratingList=data;
    })
  }
  
  sort(){
    
  }
  Search(){
    this.getAllRatings(this.Title,this.RatingValue);
  }

}
