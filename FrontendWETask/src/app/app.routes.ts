import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import {HeaderComponent} from './components/header/header.component';
import { SharedComponent} from './components/shared/shared.component';
import { SearchComponent} from './components/search/search.component';
import { IgnoredComponent} from './components/ignored/ignored.component';
import { AddComponent} from './components/add/add.component';
export const routes: Routes = [


  { path: '', component: LoginComponent },
  {
    path: 'shared',
    component: SharedComponent,
    children: [
      { path: 'add', component: AddComponent },
      { path: 'search', component: SearchComponent },
      { path: 'ignored', component: IgnoredComponent },
    { path: '', redirectTo: 'search', pathMatch: 'full' }
    ]
  },
{ path: 'header', component: HeaderComponent },
];
