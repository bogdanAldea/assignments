import { Component, Input, OnInit, ContentChild, AfterContentInit, ElementRef } from '@angular/core';
import { Product } from '../body/products';

@Component({
  selector: 'app-product-card',
  templateUrl: './product-card.component.html',
  styleUrls: ['./product-card.component.css']
})
export class ProductCardComponent implements OnInit , AfterContentInit {

  // Product object received by the parent
  @Input() product: Product;

  // COntentChild elements
  @ContentChild("productCardContent") productCardContent: ElementRef;


  constructor() { }
  ngAfterContentInit(): void {
    // log elements after initialization
    console.log(this.productCardContent)
  }

  ngOnInit(): void {
  }
}