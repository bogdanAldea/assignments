export class Product {
    name: string;
    category: string;
    price: number;
    quantity: number;

    constructor(name: string, category: string, price: number, quantity: number)
    {
        this.name = name;
        this.category = category;
        this.price = price;
        this.quantity = quantity;
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