function autoEngineeringCompany(arr) {
    let cars = new Map();

    for (let line of arr) {

        let [carBrand, carModel, producedCars] = line.split(/\s\|\s*/);

        if (!cars.has(carBrand)) {
            cars.set(carBrand, new Map());
        }
        if (!cars.get(carBrand).has(carModel)) {
            cars.get(carBrand).set(carModel, 0);
        }
        cars.get(carBrand).set(carModel, cars.get(carBrand).get(carModel) + +producedCars);
    }
    for (let [key, value] of cars) {
        console.log(key);
        for (let [model, quantity] of value) {
            console.log(`###${model} -> ${quantity}`);
        }
    }
}

autoEngineeringCompany([
    "Audi | Q7 | 1000",
    "Audi | Q6 | 100",
    "BMW | X5 | 1000",
    "BMW | X6 | 100",
    "Citroen | C4 | 123",
    "Volga | GAZ-24 | 1000000",
    "Lada | Niva | 1000000",
    "Lada | Jigula | 1000000",
    "Citroen | C4 | 22",
    "Citroen | C5 | 10",

])