import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CategoryCreateModel, CategoryModel } from '../Models/category-model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http:HttpClient) { }

  getCategoryList(){
    return this.http.get<CategoryModel[]>("https://localhost:44382/api/Category/GetAllCategory");
  }

  createCategory(cat:CategoryCreateModel){
    return this.http.post("https://localhost:44382/api/Categories/PostCategory",cat);
  }
  
  deleteCategory(id:number){
    return this.http.post("https://localhost:44382/api/Categories/DeleteCategory/"+id,null);
  }
}
