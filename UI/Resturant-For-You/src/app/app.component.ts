import { Component, OnInit } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { concatMap } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Resturant-For-You';
  constructor(public auth: AuthService) { }

  ngOnInit() {
    this.auth.isAuthenticated$.subscribe(async (loggedIn) => {
      if (!loggedIn) {
        this.auth.loginWithRedirect();
      } else {
        this.auth.getAccessTokenSilently().subscribe((token) => console.log(token));
      }
    });
  }

}
