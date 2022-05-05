import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Product } from 'src/app/models/product';

@Component({
  selector: 'app-create-product-reactive',
  templateUrl: './create-product-reactive.component.html',
  styleUrls: ['./create-product-reactive.component.css']
})
export class CreateProductReactiveComponent implements OnInit {

  // default product instantiated
  product: any;

  // Ouput event to send new product to the parent
  @Output() onProductCreated: EventEmitter<Product> = new EventEmitter<Product>();

  // Reactive Form
  productViewModel = new FormGroup({
    name: new FormControl(),
    category: new FormControl(),
    price: new FormControl([Validators.min(1)]),
    quantity: new FormControl(Validators.min(1))
  });

  constructor() { }

  ngOnInit(): void {
  }

  submitForm()
  {
    this.product = this.productViewModel.value;
    var newProduct = new Product(this.product.name, this.product.category, this.product.price, this.product.quantity);
    this.onProductCreated.emit(newProduct);
  }
}
