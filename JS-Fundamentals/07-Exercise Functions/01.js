function insideVolume(input) {

    for (let i = 0; i < input.length; i += 3) {
        let x = input[i];
        let y = input[i + 1];
        let z = input[i + 2];

        inVolume(x, y, z);
    }

    function inVolume(x, y, z) {
        let xMin = 10;
        let xMax = 50;
        let yMin = 20;
        let yMax = 80;
        let zMin = 15;
        let zMax = 50;

        if ((x >= xMin && x <= xMax) && (y >= yMin && y <= yMax) && (z >= zMin && z <= zMax)) {

            console.log("inside");

        } else {
            console.log("outside");
        }
    }
}

insideVolume([13.1, 50, 31.5,
    50, 80, 50,
    -5, 18, 43]
);