function lowestPriceInCities(input) {

    let result = new Map();

    for (let line of input) {
        let[town, product, price] = line.split(/\s*\|\s*/).filter(x=>x!== "");

        if (!result.has(product)) {
            result.set(product,new Map());
            result.get(product).set(town, +price);
        }
        if (result.get(product).has(town)) {
            result.get(product).set(town, price);
        }


    }

    for (let product of result.keys()) {
        for (let [town, price] of result.get(product)) {
            console.log(`${product} -> ${price} (${town})`);
        }
    }
}

lowestPriceInCities(["Mexico City | Audi | 1000",
    "Mexico City | BMW | 99999",
    "New York City | Mitsubishi | 10000",
    "New York City | Mitsubishi | 1000",
    "Mexico City | Audi | 100000",
    "Washington City | Mercedes | 1000",]);