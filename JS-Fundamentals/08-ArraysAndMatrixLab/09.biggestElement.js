function biggestElement(input) {
    let maxElement = Number.NEGATIVE_INFINITY;

    for (let row = 0; row < input.length; row++) {
        for (let col = 0; col < input[row].length ; col++) {
            if (input[row][col] > maxElement) {
                maxElement = input[row][col];
            }
        }
    }

    console.log(maxElement);
}

biggestElement([[3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]]

);