import { Component, Inject } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public NavBarCategories: NavBarCategory[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<NavBarCategory[]>(baseUrl + 'navBarCategories').subscribe(result => {
      this.NavBarCategories = result;
    }, error => console.error(error));
  }

  
}

interface NavBarCategory {
  navBarCategoryId: number;
  name: string;
}
