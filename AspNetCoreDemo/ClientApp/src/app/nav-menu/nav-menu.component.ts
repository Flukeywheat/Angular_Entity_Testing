import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';;


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css'],
})
export class NavMenuComponent {
  isExpanded = false;
  public NavBarCategories: NavBarCategory[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<NavBarCategory[]>(baseUrl + 'navBarCategories').subscribe(result => {
      this.NavBarCategories = result;
    }, error => console.error(error));
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}

export interface NavBarCategory {
  navBarCategoryId: number;
  name: string;
  dropDownItem: Array<object>;
}


