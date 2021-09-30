import { Actor } from "./actor.model";
import { MovieAndTvShow } from "./movieAndTvShow.model";

export class MovieAndTvShowActor{
    constructor(public movieAndTvShowActorID:number,
                public movieAndTvShowID:number,
                public movieAndTvShow:MovieAndTvShow,
                public actorID:number,
                public actor:Actor,
                public role:string,
                public roleName:string                
        ){}
}


// public int MovieAndTvShowActorID { get; set; }
// public int MovieAndTvShowID { get; set; }
// public MovieAndTvShow MovieAndTvShow { get; set; }
// public int ActorID { get; set; }
// public Actor Actor { get; set; }
// public string Role { get; set; }
// public string RoleName { get; set; }