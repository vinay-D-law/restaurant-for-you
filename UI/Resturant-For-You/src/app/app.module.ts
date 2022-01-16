import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AuthModule } from '@auth0/auth0-angular';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AuthModule.forRoot({
      domain: 'dev-typyvfyb.auth0.com',
      clientId: 'Fhxryav4gMlLbgH7amwbY1Ey7qSvIciP',
      useRefreshTokens: true,
      audience: "https://restaurants-for-you/"
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
