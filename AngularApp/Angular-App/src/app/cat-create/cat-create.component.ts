import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { CategoryCreateModel, CategoryModel } from '../Models/category-model';
import { CategoryService } from '../Services/category.service';

@Component({
  selector: 'app-cat-create',
  templateUrl: './cat-create.component.html',
  styleUrls: ['./cat-create.component.css']
})
export class CatCreateComponent implements OnInit {
  createForm=new FormGroup({
    ParentCategoryId:new FormControl(''),
    Title:new FormControl(''),
    Description:new FormControl(''),
    Status:new FormControl('')

  });
  catList:CategoryModel[];
  constructor(private catService:CategoryService, private route: Router) { }

  ngOnInit(): void {
    this.catService.getCategoryList().subscribe(data=>{
      this.catList=data;
    })
  }

  onSubmit(){
    let cat=new CategoryCreateModel();
    cat.ParentCategoryId=this.createForm.value.ParentCategoryId;
    cat.Title=this.createForm.value.Title;
    cat.Description=this.createForm.value.Description;
    cat.Status=this.createForm.value.Status;
    this.catService.createCategory(cat).subscribe(data=>{
      console.log(data);
      this.route.navigate(['/category']);      
    })
  }
}
