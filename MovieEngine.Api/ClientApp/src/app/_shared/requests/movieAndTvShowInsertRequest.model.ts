export class MovieAndTvShowInsertRequest{
    constructor(public Title:string,public Description:string,
        public Type:string,public ReleaseDate:Date,public PictureName:string,public PicturePath:string
){}
}