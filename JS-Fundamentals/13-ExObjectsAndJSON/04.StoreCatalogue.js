function storeCatalogue(arr) {

    let catalogue = new Map();

    for (let line of arr) {
        let [productName, productPrice] = line.split(/\s*:\s*/);

        catalogue.set(productName, +productPrice);
    }

    let catalogueKeys = Array.from(catalogue.keys()).sort();


    for (let i = 0; i < catalogueKeys.length;) {

        let firstLetter = catalogueKeys[i].charAt(0);
        console.log(firstLetter);

        while (i < catalogueKeys.length && firstLetter === catalogueKeys[i].charAt(0) ) {

            console.log(`  ${catalogueKeys[i]}: ${catalogue.get(catalogueKeys[i])}`);
            i++;

        }
    }
}


storeCatalogue(["Appricot : 20.4",
    "Fridge : 1500",
    "TV : 1499",
    "Deodorant : 10",
    "Boiler : 300",
    "Apple : 1.25",
    "Anti-Bug Spray : 15",
    "T-Shirt : 10",
]);