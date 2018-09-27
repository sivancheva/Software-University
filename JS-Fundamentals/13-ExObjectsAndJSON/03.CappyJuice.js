function cappyJuice(arr) {
    let bottlesCountEnd = new Map();
    let restOfJuice = new Map();

    for (let line of arr) {

        let [juice, quantity] = line.split(/\s*=>\s*/);

        if (!restOfJuice.has(juice)) {
            restOfJuice.set(juice, 0);
        }
        restOfJuice.set(juice, restOfJuice.get(juice) + +quantity);

        let bottlesCount = Math.floor(restOfJuice.get(juice) / 1000);
        let rest = restOfJuice.get(juice) % 1000;

        if (bottlesCount > 0 && !bottlesCountEnd.has(juice)) {
            bottlesCountEnd.set(juice, 0);
        }
        if(bottlesCountEnd.has(juice) &&  bottlesCount > 0){
            bottlesCountEnd.set(juice, bottlesCountEnd.get(juice) + +bottlesCount);
        }
        restOfJuice.set(juice, rest);
    }

    for (let [key, value] of bottlesCountEnd) {
        if (value > 0) {
            console.log(`${key} => ${value}`);
        }
    }
}

cappyJuice(["Kiwi => 234",
    "Pear => 2345",
    "Kiwi => 4567",
    "Pear => 5678",
]);