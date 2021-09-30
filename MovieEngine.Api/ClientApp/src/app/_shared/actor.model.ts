export class Actor{
    constructor(public actorID:number,public firstName:string,public lastName:string,
                public gender:string,public dateOfBirth:Date        
        ){}
}

// public int ActorID { get; set; }
// public string FirstName { get; set; }
// public string LastName { get; set; }
// public string Gender { get; set; }
// public DateTime DateOfBirth { get; set; }

// public ICollection<MovieAndTvShowActor> MovieAndTvShowActor { get; set; }