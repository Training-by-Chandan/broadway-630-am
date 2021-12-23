import { Component, OnInit } from '@angular/core';
import { CategoryModel } from '../Models/category-model';
import { CategoryService } from '../Services/category.service';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {
  list:CategoryModel[];

  constructor(private catService:CategoryService) { }

  ngOnInit(): void {
    this.catService.getCategoryList().subscribe(data=>{
      this.list=data;
    })
  }

  Delete(id:number){
    this.catService.deleteCategory(id).subscribe(data=>{
      this.catService.getCategoryList().subscribe(data=>{
        this.list=data;
      })
    })
  }

}
