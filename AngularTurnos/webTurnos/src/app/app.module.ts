import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import {Rutas  } from "./app-routing.module";
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/common/navbar/navbar.component';
import { BodyComponent } from './components/common/body/body.component';
import { LoginComponent } from './components/common/login/login.component';
import { RegistroComponent } from './components/common/registro/registro.component';
import { UsuarioComponent } from './components/model/usuario/usuario.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    BodyComponent,
    LoginComponent,
    RegistroComponent,
    UsuarioComponent
  ],
  imports: [
    BrowserModule,
    Rutas
    
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
