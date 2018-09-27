function roadradar(input) {
    "use strict";
    let currSpeed = input[0];
    let driveArea = input[1];

    switch (driveArea) {
        case "motorway":
            console.log(state(130 - currSpeed));
            break;
        case  "interstate":
            console.log(state(90 - currSpeed));
            break;
        case  "city":
            console.log(state(50 - currSpeed));
            break;
        case "residential":
            console.log(state(20 - currSpeed));
            break;
    }
    function state(input) {
        let speedDifference = input;
        if (speedDifference >= 0) {
            return "";
        }
        if (speedDifference < 0) {
            let absSpeedDifference = Math.abs(speedDifference);
            if (absSpeedDifference > 0 && absSpeedDifference <= 20) {
                return "speeding";
            }else if (absSpeedDifference > 20 && absSpeedDifference <= 40) {
                return "excessive speeding";
            }else {
                return "reckless driving";
            }
        }
    }
}

roadradar([40, "city"]);
roadradar([21, "residential"]);
roadradar([120, "interstate"]);
roadradar([200, "motorway"]);