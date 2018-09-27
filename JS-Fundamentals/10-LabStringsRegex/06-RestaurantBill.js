function restaurantBill(arr) {

    let products = arr.filter((x,i)=> i%2 ===0 );
    let sum = arr.filter((x,i) => i%2 !== 0).reduce((a,b) => +a + +b);

    console.log(`You purchased ${products.join(", ")} for a total sum of ${sum}`);
}

restaurantBill(['Cola', '1.35', 'Pancakes', '2.88']);