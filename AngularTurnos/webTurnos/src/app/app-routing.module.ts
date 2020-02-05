import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BodyComponent } from './components/common/body/body.component';
import { LoginComponent } from './components/common/login/login.component';
import { RegistroComponent } from "./components/common/registro/registro.component";

const routes: Routes = [
  { path: 'home', component: BodyComponent },
  { path: 'login', component: LoginComponent },
  { path:'login/registro',component:RegistroComponent}
];


export const Rutas=RouterModule.forRoot(routes)
