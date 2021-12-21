import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  forms=new FormGroup({
    name:new FormControl(''),
    address:new FormControl('')
  });
  inputstring:string="";
  constructor() { }

  ngOnInit(): void {
  }
  onSubmit(){
    alert(this.forms.value.name +', '+this.forms.value.address);
  }
  TextChange(event:any){
    this.inputstring=event.target.value;
  }

}
