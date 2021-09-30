import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Rating } from "../_shared/rating.model";
import { RatingInsertRequest } from "../_shared/requests/ratingInsertRequest.model";

@Injectable({ providedIn: 'root' })
export class RatingService {
    constructor(public http: HttpClient) { }

    getRatings(Title: string, RatingValue?: number) {
        let params=new HttpParams()
        .set("Title",Title)
        .set("RatingValue", RatingValue!=null ? RatingValue.toString() : '');

        return this.http.get<Rating[]>('https://localhost:5001/api/Rating',{
            params:params
        });
    }
    addRating(rating:RatingInsertRequest){
        return this.http.post('https://localhost:5001/api/Rating',rating);
    }
}