import { Component, Input, OnInit } from '@angular/core';
import { NavBarCategory } from "../nav-menu.component";

@Component({
  selector: 'nav-nav-dropdown',
  templateUrl: './nav-dropdown.component.html',
  styleUrls: ['./nav-dropdown.component.css'],
})
export class NavDropDownComponent {
  @Input() Category: NavBarCategory;
  isValid: Boolean = false;
}
