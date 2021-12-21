import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-new-component',
  templateUrl: './new-component.component.html',
  styleUrls: ['./new-component.component.css']
})
export class NewComponentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
   btnClick(){
   // alert("Button Clicked");
    this.subtitleShow = !this.subtitleShow;
   }
   subtitleShow:boolean=true;
}
