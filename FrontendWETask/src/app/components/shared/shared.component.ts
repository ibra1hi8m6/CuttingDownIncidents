import { Component } from '@angular/core';
import { HeaderComponent } from '../header/header.component';
import {  RouterModule, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-shared',
  
  imports: [HeaderComponent,RouterModule,RouterOutlet],
  templateUrl: './shared.component.html',
  styleUrl: './shared.component.css'
})
export class SharedComponent {

}
