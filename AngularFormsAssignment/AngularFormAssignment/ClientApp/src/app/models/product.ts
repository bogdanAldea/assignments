
export class Product {
    private _name: string;
    private _category: string;
    private _price: number;
    private _quantity: number;

    constructor(name: string, category: string, price: number, quantity: number)
    {
        this._name = name;
        this._category = category;
        this._price = price;
        this._quantity = quantity;
    }

    public get Name(): string {
        return this._name
    }

    public set Name(value: string) {
        this._name = value
    }

    public get Category() : string {
        return this._category
    }

    public set Category(value: string) {
        this._category = value
    }

    public get Price(): number {
        return this._price
    }

    public set Price(value: number) {
        this._price = value
    }

    public get Quantity(): number {
        return this._quantity
    }

    public set Quantity(value: number) {
        this._quantity = value
    }
}


export const productList = [
    new Product("Razer", "Headphones", 260.00, 4),
    new Product("Steel Series", "Headphones", 400.00, 5),
    new Product("Lenovo", "Laptop", 960.00, 10),
    new Product("SamsungTV", "TV", 540.00, 2),
    new Product("Samsung Evo Plus", "PC Accesories", 160.00, 12),
    new Product("Asus", "Pc", 1260.00, 4),
    new Product("Pixel", "Smartphone", 260.00, 4),
]