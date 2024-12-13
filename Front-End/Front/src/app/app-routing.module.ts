import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignUpComponent } from './sign-up/sign-up.component';
import { RegisteComponent } from './registe/registe.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path:'login' ,component : SignUpComponent },
  {path : 'signup', component : RegisteComponent },
  {path : 'home', component : HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
