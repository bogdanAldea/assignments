import { Component, OnInit } from '@angular/core';

export class Apartment {
  private _numberInBuilding: number;
  private _residents: number;
  private _floor;
  private _payment!: number;
  private _owner!: string;
  private _paymentIsPaid: boolean

  constructor(numberInBuilding: number, residents: number, floor: number, payment: number)
  {
    this._numberInBuilding = numberInBuilding
    this._residents = residents
    this._floor = floor
    this._paymentIsPaid = false
    this._payment = payment
  }

  public get Owner(): string
  {
    return this._owner
  }

  public set Owner(name: string)
  {
    this._owner = name
  }

  public get NumberInBuilding(): number
  {
    return this._numberInBuilding
  }

  public get Residents(): number
  {
    return this._residents
  }

  public set Residents(residents: number)
  {
    this._residents = residents
  }

  public get Floor(): number {
    return this._floor
  }

  public get Payment(): number
  {
    return this._payment
  }

  public set Payment(amount: number)
  {
    this._payment = amount
  }

  public get PaymentIsPaid(): boolean
  {
    return this._paymentIsPaid
  }

  public set PaymentIsPaid(isPaid: boolean)
  {
    this._paymentIsPaid = isPaid
  }

}

@Component({
  selector: 'app-apartment-list',
  templateUrl: './apartment-list.component.html',
  styleUrls: ['./apartment-list.component.css']
})
export class ApartmentListComponent implements OnInit {

  // Defined properties

  pageTitle: string = "Apartments"
  value: number = 0;
  apartments: Apartment[] = [
    new Apartment(1, 2, 0, 1200.30),
    new Apartment(2, 1, 0, 540.20),
    new Apartment(3, 0, 1, 180.20),
    new Apartment(4, 0, 1, 75.50),
    new Apartment(5, 3, 2, 320.00),
    new Apartment(6, 4, 2, 210.00),
  ]

  constructor() { }

  ngOnInit(): void {
  }

  updatePayments(apartmentNumber: number) 
  {
    var apartment = this.apartments.filter(apartment => apartment.NumberInBuilding == apartmentNumber + 1)[0]
    apartment.PaymentIsPaid = false;
  }

  registerPayment(apartmentNumber: number)
  {
    var apartment = this.apartments.filter(apartment => apartment.NumberInBuilding == apartmentNumber + 1)[0]
    if (!apartment.PaymentIsPaid)
    {
      apartment.Payment = 0.00
      apartment.PaymentIsPaid = true
    }
  }

}