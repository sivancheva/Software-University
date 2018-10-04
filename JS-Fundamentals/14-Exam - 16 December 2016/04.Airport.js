function airport(inputArr) {

    let planesAtAirport = [];
    let passengersByTown = new Map();
    let planesByTown = new Map();

    for (let line of inputArr) {

        let [planeId, town, passengersCount, action] = line.split(' ');

        let passengers = +passengersCount;
        if (action === 'land') {
            if (!planesAtAirport.includes(planeId)) {
                planesAtAirport.push(planeId);

                if (!passengersByTown.has(town)) {
                    passengersByTown.set(town, [0, 0]);
                }
                passengersByTown.get(town)[0] += passengers;

                if (!planesByTown.has(town)) {
                    planesByTown.set(town, new Set());
                }
                planesByTown.get(town).add(planeId);
            }
        } else {
            if (planesAtAirport.includes(planeId)) {
                planesAtAirport.splice(planesAtAirport.indexOf(planeId), 1);

                if (!passengersByTown.has(town)) {
                    passengersByTown.set(town, [0, 0]);
                }
                passengersByTown.get(town)[1] += passengers;

                if (!planesByTown.has(town)) {
                    planesByTown.set(town, new Set());
                }
                planesByTown.get(town).add(planeId);
            }
        }
    }

    let sortedPlanes = planesAtAirport.sort((a, b) => {
        'use strict';
        return a.localeCompare(b);
    });

    let sortedPassengersByTown = [...passengersByTown.entries()].sort((obj1, obj2) => {
        'use strict';
        let obj1Arrivals = obj1[1][0]; // na obekt1, vzimame values, kudeto na pos 0 sa zaminava6tite
        let obj2Arrivals = obj2[1][0];
        let difference = obj2Arrivals - obj1Arrivals;

        if (difference === 0) {
            return obj1[0].localeCompare(obj2[0]);
        } else {
            return difference;
        }
    });
    //print
    console.log('Planes left:');
    for (let plane of sortedPlanes) {
        console.log(`- ${plane}`);
    }

    for (let [town, values] of sortedPassengersByTown) {
        console.log(town);
        console.log(`Arrivals: ${values[0]}\nDepartures: ${values[1]}`);
        console.log('Planes:');

        for (let plane of [...planesByTown.get(town)].sort((a, b) => {
            return a.localeCompare(b)
        })) {
            console.log(`-- ${plane}`);
        }
    }
}

airport([ "Airbus Paris 356 land",
    "Airbus London 321 land",
    "Airbus Paris 213 depart",
    "Airbus Ljubljana 250 land" ]);