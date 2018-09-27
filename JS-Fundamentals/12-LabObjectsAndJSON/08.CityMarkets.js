function cityMarkets(input) {

    let result = new Map();

    for (let line of input) {

        let [town, product, amountOfSales,priceForOneUnit] = line.split(/\s*->\s* | :/);

        if (!result.has(town)) {
            result.set(town, new Map());
        }
        result.get(town).set(product, Number(amountOfSales)*Number(priceForOneUnit));
    }
    for (let town of result.keys()) {
        console.log(`Town - ${town}`);
        for (let [product, income] of result.get(town)) {
            console.log(`$$$${product} : ${income}`);
        }
    }
}

cityMarkets(['Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3']
);