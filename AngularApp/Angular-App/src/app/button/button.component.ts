import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'appbutton',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Input('buttontext') buttontext="Click me";
  constructor() { }

  ngOnInit(): void {
  }

}
