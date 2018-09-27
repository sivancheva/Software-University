function populationInTown(arr) {
    let towns = new Map();

    for (let line of arr) {

        let [town, population]= line.split(/\s*<->\s*/);

        if (!towns.has(town)) {
            towns.set(town, 0);
        }
        towns.set(town, towns.get(town) + Number(population));
    }

    for (let [key, value] of towns) {
        console.log(`${key} : ${value}`);
    }
}

populationInTown(['Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000']
);