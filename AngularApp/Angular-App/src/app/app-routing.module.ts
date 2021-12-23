import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { NewComponentComponent } from './new-component/new-component.component';
import { BodyComponent } from './body/body.component';
import { FormComponent } from './form/form.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { CatCreateComponent } from './cat-create/cat-create.component';

const appRoutes: Routes = [
  { path:'header', component: HeaderComponent },
  { path:'card', component: NewComponentComponent },
  { path:'body', component: BodyComponent},
  { path:'form', component: FormComponent},
  { path:'category', component: CategoryListComponent},
  { path:'category-create', component: CatCreateComponent},
  { path:'', redirectTo:'/body', pathMatch:'full' }
];


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(
      appRoutes
      
    )
  ]
})
export class AppRoutingModule { }
