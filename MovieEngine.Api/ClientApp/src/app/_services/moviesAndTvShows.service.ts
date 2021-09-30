import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { MovieAndTvShow } from "../_shared/movieAndTvShow.model";
import { MovieAndTvShowInsertRequest } from "../_shared/requests/movieAndTvShowInsertRequest.model";

@Injectable({providedIn:'root'})
export class MoviesAndTvShows{
    constructor(private http:HttpClient){}

    getMoviesAndTvShows(Title:string,Type:string){
        let params=new HttpParams()
        .set("Title",Title)
        .set("Type",Type);
        return this.http.get<MovieAndTvShow[]>('https://localhost:5001/api/MovieAndTvShow',{
            params:params
        });
    }
    addMovieAndTvShow(request:MovieAndTvShowInsertRequest){
            return this.http.post('https://localhost:5001/api/MovieAndTvShow',request);
    }
    getMovieTvShowById(id){
        return this.http.get<MovieAndTvShow>('https://localhost:5001/api/MovieAndTvShow/'+id);
    }
}