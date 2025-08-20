import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { provideRouter } from '@angular/router';
import { importProvidersFrom } from '@angular/core';
import { routes } from './app/app.routes';
import { HttpClientModule, provideHttpClient } from '@angular/common/http';
bootstrapApplication(AppComponent,  {
  providers: [provideRouter(routes),importProvidersFrom(HttpClientModule),
    provideHttpClient()],

})
  .catch((err) => console.error(err));
