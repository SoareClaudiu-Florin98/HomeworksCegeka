var fs = require('file-system');
var file = 'products.json';
var encode = 'utf8';
var products;
fs.readFile(file, encode, function (err, data) {
    products = JSON.parse(data);
    console.log(products);
});
setTimeout(function () { console.log(products); }, 200);
function displayAvailibleStock() {
    for (var _i = 0, products_1 = products; _i < products_1.length; _i++) {
        var product = products_1[_i];
        console.log("Product name :" + product.name + ", price: " + product.price + ", likeability: " + product.likeability + ", dicount: " + product.discount + ", stock: " + product.stock);
    }
}
function makeAPurchase(name) {
    var myProduct = products.find(function (product) {
        if (product.name === name) {
            if (product.stock > 0) {
                product.stock -= 1;
                return product;
            }
            else {
                throw 'Nu mai exista acest produs pe stoc !';
            }
        }
    });
    if (myProduct) {
        console.log("Ati cumparat produsul " + myProduct.name + " la pretul de " + (myProduct.price - myProduct.discount));
    }
    else {
        throw 'Nu exista acest produs';
    }
}
function addADiscount(product, discount) {
    if (product.price > 1000) {
        product.discount = discount;
    }
}
function incrementLikeability(product) {
    product.likeability++;
}
function addDiscountBasedOnLikeability(likeability) {
    products.find(function (product) {
        if (product.likeability > likeability) {
            product.discount += 10;
        }
    });
}
var orders = new Array();
function placeOrder(customer, quantity) {
    var myCustomer = { id: 0, name: 'Claudiu' };
    var order = { customer: myCustomer, quantity: 0 };
    order.customer = customer;
    order.quantity = quantity;
    orders.push(order);
}
function refillStockforSoldOutProduct(myproduct, refillNumber) {
    products.find(function (product) {
        if (product.name === myproduct.name) {
            if (product.stock <= 0) {
                product.stock = refillNumber;
            }
        }
    });
}
setTimeout(displayAvailibleStock, 200);
setTimeout(function () { makeAPurchase('Pantaloni'); }, 200);
setTimeout(displayAvailibleStock, 200);
setTimeout(function () { addADiscount(products[0], 20); }, 200);
setTimeout(function () { incrementLikeability(products[0]); }, 200);
setTimeout(function () { incrementLikeability(products[0]); }, 200);
setTimeout(function () { incrementLikeability(products[0]); }, 200);
setTimeout(displayAvailibleStock, 200);
setTimeout(function () { addDiscountBasedOnLikeability(2); }, 200);
setTimeout(displayAvailibleStock, 200);
var testCustomer = { id: 1, name: "Andrei" };
var testCustomer2 = { id: 2, name: "Dragos" };
setTimeout(function () { placeOrder(testCustomer, 10); }, 200);
setTimeout(function () { placeOrder(testCustomer2, 20); }, 200);
setTimeout(function () { console.log(orders); }, 200);
setTimeout(function () { refillStockforSoldOutProduct(products[3], 20); }, 200);
setTimeout(displayAvailibleStock, 200);
