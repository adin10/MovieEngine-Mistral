export class MovieAndTvShow{
    constructor(public movieAndTvShowID:number,public title:string,public description:string,
                public type:string,public releaseDate:Date
        ){}
}

// public int MovieAndTvShowID { get; set; }
// public string Title { get; set; }
// public string Description { get; set; }
// public string Type { get; set; }
// public DateTime ReleaseDate { get; set; }
// public byte[] CoverImage { get; set; }