function townsToJSON(inputArr) {

    let towns = [];
    for (let line of inputArr.slice(1)) {

        let [empty, town,latitude ,longitude ] = line.split(/\s*\|\s*/);
        let obj = {Town: town, Latitude: +latitude, Longitude: +longitude}
        towns.push(obj);
    }
    towns = JSON.stringify(towns);
    console.log( towns);
    
    //console.log(JSON.stringify(towns)); // su6toto e koto onova gore

}

townsToJSON(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']);
