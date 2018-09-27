function equalNeighbours(input) {
    let countNeighbours = 0;

    for (let row = 0; row < input.length-1; row++) {
        for (let col = 0; col < input[row].length; col++) {

            if (input[row][col] === input[row][col + 1]) {
                countNeighbours++;
            }
            if (input[row][col] === input[row+1][col]) {
                countNeighbours++;
            }
        }
    }
    for (let col = 0; col < input[input.length-1].length; col++) {

        if (input[input.length-1][col] === input[input.length-1][col + 1]) {
            countNeighbours++;
        }
    }
    console.log(countNeighbours);
}
equalNeighbours([[2 ,2, 5, 7, 4],
                 [4, 0, 5, 3, 4],
                 [2, 5, 5, 4, 2]]
);


