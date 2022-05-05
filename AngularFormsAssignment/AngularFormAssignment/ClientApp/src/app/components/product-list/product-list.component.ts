import { Component, OnInit } from '@angular/core';
import { Product, productList } from 'src/app/models/product';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  // product list
  products: Product[] = productList;

  constructor() { }

  ngOnInit(): void {
  }

  addNewProductToList(product: Product)
  {
    this.products.push(product);
  }

}
