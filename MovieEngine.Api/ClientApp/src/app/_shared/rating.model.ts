import { MovieAndTvShow } from "./movieAndTvShow.model";

export class Rating{
    constructor(public ratingID:number,public movieAndTvShowId:number,
                public movieAndTvShow:MovieAndTvShow,public ratingValue:number){}
}

// public int RatingID { get; set; }
// public int MovieAndTvShowId { get; set; }
// public MovieAndTvShow MovieAndTvShow { get; set; }
// public int RatingValue { get; set; }