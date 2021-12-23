export class CategoryModel {
    public Description: string;
    public Id: number;
    public Title: string;
    public ParentCategoryId: number;
    public ParentCategoryName: string ;
    public Status:boolean
}


export class CategoryCreateModel{
    public ParentCategoryId:number; 
    public Title:string;
    public Description:string;
    public Status:boolean;
}