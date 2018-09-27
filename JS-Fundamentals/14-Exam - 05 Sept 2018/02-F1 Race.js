function f1Race(arr) {

    let drivers = arr[0].split(" ").map(x => x.trim());

    for (let line of arr.slice(1)) {
        let [command, driverName] = line.split(" ").map(x => x.trim());

        switch (command) {
            case "Join":
                join(drivers, driverName);
                break;

            case "Crash":
                crash(drivers, driverName);
                break;

            case "Pit":
                pit(drivers, driverName);
                break;

            case "Overtake":
                overtake(drivers, driverName);

            default:
                break;
        }
    }

    console.log(drivers.join(" ~ "));

    function join(arr, drivername) {
        if (!arr.includes(drivername)) {
            return arr.push(drivername);
        }
    }

    function crash(arr, drivername) {
        if (arr.includes(drivername)) {
            let index = arr.indexOf(drivername);
            arr = arr.splice(index, 1);
        }
        return arr;

    }

    function pit(arr, drivername) {

        let copyOfArr = arr.slice(0, arr.length);

        if (arr.includes(drivername)) {
            let index = copyOfArr.indexOf(drivername);
            if (index < arr.length-1) {
                arr[index] = arr[index+1];
                index++;
                arr[index] = drivername;
            }
            return arr;
        }
    }

    function overtake(arr, drivername) {
        let copyOfArr = arr.slice(0, arr.length);

        if (arr.includes(drivername)) {
            let index = copyOfArr.indexOf(drivername);
            if (index > 0) {
                arr[index] = arr[index-1];
                index--;
                arr[index] = drivername;
            }
        }
    }

}

// f1Race(["Vetel Hamilton Slavi",
//     "Pit Hamilton",
//     "Overtake Vetel",
//     "Crash Slavi"]
// );

f1Race(["Vetel Hamilton Raikonnen Botas Slavi",
    "Pit Hamilton",
    "Overtake LeClerc",
    "Join Ricardo",
    "Crash Botas",
    "Overtake Ricardo",
    "Overtake Ricardo",
    "Overtake Ricardo",
    "Crash Slavi"
]);