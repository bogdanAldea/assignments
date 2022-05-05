import { AfterContentInit, AfterViewInit, Component, ContentChild, ElementRef, OnInit, ViewChild, ViewChildren } from '@angular/core';
import { ProductCardComponent } from '../product-card/product-card.component';
import { productList, Product } from './products';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})
export class BodyComponent implements OnInit, AfterViewInit {

  // define list of products that will be displayed on the page
  products: Product[] = productList;

  // define ViewChild variable
  @ViewChildren("productCardView") productCardView: ProductCardComponent;

  ngAfterViewInit(): void {
    // log the content after initialization
    console.log(this.productCardView);
  }

  ngOnInit(): void {
  }

  public AddProductToList(product: Product)
  {
    this.products.push(product);
    console.log(product)
  }

}
