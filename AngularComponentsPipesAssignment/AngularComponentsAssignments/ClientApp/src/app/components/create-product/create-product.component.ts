import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Product } from '../body/products';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
export class CreateProductComponent implements OnInit {

  // New object that will be sent to the parent
  @Output() newProduct: EventEmitter<Product> = new EventEmitter<Product>();
  
  constructor() { }

  ngOnInit(): void {
  }

  public AddNewProduct(name: string, category: string, price: string, quantity: string)
  {
    // convert price to number
    var validPrice = parseFloat(price);
    // convert quantity to number
    var validQuantity = parseInt(quantity);
    // create new Product object
    var product = new Product(name, category, validPrice, validQuantity);
    this.newProduct.emit(product);
  }
}