var fs = require('file-system');

interface MyProduct {
    name: string
    price: number
    likeability:number
    discount:number
    stock:number
}
interface Customer {
    id: number
    name:string
}
interface Order{
    customer: Customer
    quantity : number
    products : MyProduct[]
}
const file = 'products.json'
const encode = 'utf8'
var products:MyProduct[]
fs.readFile(file, encode, (err, data) => {
    products = JSON.parse(data) as MyProduct[]
    console.log(products)    
})
setTimeout(function(){ console.log(products); }, 200);
function displayAvailibleStock(){ 
    for(let product of products ){
        console.log(`Product name :${product.name}, price: ${product.price}, likeability: ${product.likeability}, dicount: ${product.discount}, stock: ${product.stock}`);
    }
}
function makeAPurchase(name:string){
    let myProduct =products.find((product )=> {
        if(product.name === name){
            if(product.stock >0){
                product.stock -=1 ; 
                return product;
            }
            else{ 
                throw 'Nu mai exista acest produs pe stoc !'
            }
        }
    })
    if(myProduct){
        console.log(`Ati cumparat produsul ${myProduct.name} la pretul de ${myProduct.price- myProduct.discount}`)
    }else{
        throw 'Nu exista acest produs'
    }
}
function addADiscount(product: MyProduct, discount :number){
    if(product.price > 1000){
        product.discount= discount ; 
    }
}
function incrementLikeability(product:MyProduct){
    product.likeability ++ ;     
}

function addDiscountBasedOnLikeability(likeability:number){
    products.find(product => {
        if(product.likeability > likeability){
            product.discount +=10 ; 
        }
    })

}

var orders :Order[] = new Array(); 
function placeOrder(customer: Customer, quantity: number, productsParams: MyProduct[]){
    let myCustomer: Customer = {id:0 , name: 'unknown'} ; 
    let order:Order = {customer: myCustomer, quantity:0,products} ; 
    order.customer = customer ; 
    order.quantity= quantity ;
    order.products = productsParams;
    orders.push(order) ;   
}
function refillStockforSoldOutProduct(myproduct : MyProduct, refillNumber){
    products.find(product =>{
        if(product.name ===myproduct.name){
            if(product.stock <= 0){
                product.stock = refillNumber ; 
            }
        }
    })
}

setTimeout(displayAvailibleStock, 200);
setTimeout(function(){makeAPurchase('Pantaloni')}, 200);
setTimeout(displayAvailibleStock, 200);
setTimeout(function(){addADiscount(products[0], 20)}, 200);
setTimeout(function(){incrementLikeability(products[0])}, 200);
setTimeout(function(){incrementLikeability(products[0])}, 200);
setTimeout(function(){incrementLikeability(products[0])}, 200);
setTimeout(displayAvailibleStock, 200);
setTimeout(function(){addDiscountBasedOnLikeability(2)}, 200);
setTimeout(displayAvailibleStock, 200);
let testCustomer :Customer= {id:1 ,name: "Andrei"} ; 
let testCustomer2 :Customer= {id:2 ,name: "Dragos"} ; 
setTimeout(function(){placeOrder(testCustomer,10,products)},200)
setTimeout(function(){placeOrder(testCustomer2,20,products)},200)
setTimeout(function() {console.log(orders)}, 200) ; 
setTimeout(function(){refillStockforSoldOutProduct(products[3],20)}, 200);
setTimeout(displayAvailibleStock, 200);










