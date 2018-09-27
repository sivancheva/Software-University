function diagonalSums(input) {

    let result = [0, 0];

    for (let row = 0; row < input.length; row++) {

        result[0] += input[row][row];
        result[1] += input[row][input.length - 1-row];
    }
    console.log(result.join(" "));
}

diagonalSums([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]

);