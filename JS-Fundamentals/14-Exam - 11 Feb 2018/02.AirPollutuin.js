function airPolution(inputMatrix, commandArray) {

    let matrix = [];

    for (let i = 0; i < 5; i++) {
        let subArr = [];
        subArr = inputMatrix[i].split(" ").map(x=>Number(x));
        matrix.push(subArr);
    }
    for (let commandPair of commandArray) {

        let [command, index] = commandPair.split(" ");

        switch (command) {
            case "breeze":
                breeze(matrix, index);
                break;
            case  "gale":
                gale(matrix, index);
                break;

            case "smog":
                smog(matrix, index);
                break;
        }
    }

    let polutedAreas = [];

    for (let row = 0; row < 5 ; row++) {
        for (let col = 0; col < 5; col++) {

            if (matrix[row][col] >= 50) {

                let coordinates = `[${row}-${col}]`;
                polutedAreas.push(coordinates);
            }
        }
    }

    if (polutedAreas.length  === 0) {
        console.log("No polluted areas");
    }else{
        console.log("Polluted areas: " + polutedAreas.join(", "));
    }


    function breeze(matrix, row) {

        for (let col = 0; col < 5 ; col++) {
            if (matrix[row][col] - 15 < 0) {
                matrix[row][col] = 0;
            }else{
                matrix[row][col] -= 15;
            }
        }
        return matrix;
    }

    function gale(matrix, col) {
        for (let i = 0; i < 5; i++) {
            if (  matrix[i][col] - 20 <0) {
                matrix[i][col]  = 0;
            }else{
                matrix[i][col]  -= 20;
            }
        }
        return matrix;
    }

    function smog(matrix, index) {
        for (let row = 0; row < 5 ; row++) {
            for (let col = 0; col < 5 ; col++) {
                matrix[row][col] += +index;
            }
        }

        return matrix;
    }

}

airPolution(["5 7 72 14 4",
        "41 35 37 27 33",
        "23 16 27 42 12",
        "2 20 28 39 14",
        "16 34 31 10 24"],
    ["breeze 1", "gale 2", "smog 25"]
);

airPolution([
    "5 7 2 14 4",
    "21 14 2 5 3",
    "3 16 7 42 12",
    "2 20 8 39 14",
    "7 34 1 10 24",
],
    ["breeze 1", "gale 2", "smog 35"]
);