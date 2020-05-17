import { Component } from '@angular/core';
import { dropDownCategories } from "../Enums/Enums";


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css'],
})
export class NavMenuComponent {
  isExpanded = false;
  dropDownCategories: Array<dropDownCategories> =
    [dropDownCategories.Industries, dropDownCategories.Products, dropDownCategories.Company
      , dropDownCategories.Contact_Us, dropDownCategories.Support];

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}


