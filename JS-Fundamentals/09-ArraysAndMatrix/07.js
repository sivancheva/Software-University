function magicMatrix(matrix) {

    let isMagic = true;
    let sumRows = 0;
    let sumCols = 0;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            sumRows += matrix[row][col];
        }
        for (let col = 0; col < matrix.length; col++) {
            sumCols += matrix[col][row];
        }
        if (sumCols !== sumRows) {
            isMagic = false;
            break;
        }
    }
    console.log(isMagic);
}
magicMatrix([[4, 5], [6], [5, 5, 5, 1]]);

//magicMatrix([[4, 5, 6], [6, 5, 4], [5, 5, 5]]);
// magicMatrix([[11, 32, 45],
//     [21, 0, 1],
//     [21, 1, 1]]);
// magicMatrix(
//     [[1, 0, 0],
//         [0, 0, 1],
//         [0, 1, 0]]);


