import { Component, Input } from '@angular/core';
import { dropDownCategories } from "../../Enums/Enums";

@Component({
  selector: 'nav-nav-dropdown',
  templateUrl: './nav-dropdown.component.html',
  styleUrls: ['./nav-dropdown.component.css'],
})
export class NavDropDownComponent {
  @Input() Category: dropDownCategories;
  CatEnum = dropDownCategories;

  IndustriesItemsPaceholder: Array<string> = ["Transit & Rail", "Paratransit"];

  constructor() {
    console.log(this.Category);
  }
}
