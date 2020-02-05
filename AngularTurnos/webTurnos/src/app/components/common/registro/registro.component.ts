import { Component, OnInit } from '@angular/core';
import { log } from 'util';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {
  vista1:boolean;
  vista2:boolean=true;
  constructor() {
    this.vista1=false;
    this.vista2=true;
    

   }

  ngOnInit(): void {
  }
   funcion() {
    this.vista1=this.vista2;
    this.vista2=!this.vista1
    
    
  }

}
