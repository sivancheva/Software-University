function diagonalAttack(matrix) {

    let inputMatrix = matrix;
    let copyOfMatrix = [[]];

    for (let i = 0; i < inputMatrix.length; i++) {
        copyOfMatrix[i] = inputMatrix[i].split(" ").map(Number);
    }
     //console.log(copyOfMatrix);

    let equalDiagonals = true;

    let firstMainDiagonal = 0;
    let secondMainDiagonal = 0;

    for (let row = 0; row < copyOfMatrix.length; row++) {
        firstMainDiagonal += copyOfMatrix[row][row];
        secondMainDiagonal += copyOfMatrix[row][copyOfMatrix.length - row - 1];
    }
    if (firstMainDiagonal !== secondMainDiagonal) {
        equalDiagonals = false;
    }
    if (equalDiagonals) {
        let colToSkipD1 =0;
        let colToSkipD2 =copyOfMatrix[0].length-1;

        for (let row = 0; row < copyOfMatrix.length; row++) {
            for (let col = 0; col < copyOfMatrix[row].length; col++) {
                if ((col !== colToSkipD1)&& (col !== colToSkipD2)) {
                    copyOfMatrix[row][col] = firstMainDiagonal;
                }
            }
            colToSkipD1++;
            colToSkipD2--;
        }
    }
    print(copyOfMatrix);

    function print(matrix) {
        for (let i = 0; i < matrix.length ; i++) {
            console.log(matrix[i].join(" "));
        }
    }
}

diagonalAttack(['5 3 12 3 1    ',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']
);