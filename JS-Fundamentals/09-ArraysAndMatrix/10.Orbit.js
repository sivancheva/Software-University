function orbit(input) {
    let rows = input[0];
    let cols = input[1];
    let starRow = input[2];
    let starCol = input[3];

    let matrix = [];
    for(let i=0; i<rows; i++) {
        matrix.push([]);
    }

    for(let row = 0; row< rows; row++) {
        for(let col=0; col<cols; col++) {
            matrix[row][col] = Math.max(Math.abs(row - starRow), Math.abs(col - starCol)) + 1;
        }
    }

    console.log(matrix.map(row => row.join(" ")).join("\n"));
}
orbit([5, 5, 2, 2]);


// function orbit(input) {
//     let cols = Number(input[0]);
//     let rows =  Number(input[1]);
//     let col =  Number(input[2]);
//     let row =  Number(input[3]);
//
//     let matrix = [[]];
//
//     for (let r = 0; r < rows ; r++) {
//         matrix[r] =[];
//         for (let c = 0; c < cols ; c++) {
//            matrix[r][c] = 0;
//         }
//     }
//     matrix[col][row] = 1;
//     let countOfcells = cols*rows-1;
//     let numToFill = 1;
//     while (countOfcells > 0 ) {
//
//         try {
//             for (let i = 0; i < 2*numToFill+1  ; i++) {
//                 matrix[row-numToFill][col-numToFill+i] = numToFill+1;
//                 countOfcells--;
//             }
//         }
//         catch(err) {
//             //todo;
//         }
//
//         try {
//             for (let i = 0; i < 2*numToFill+1  ; i++) {
//                 matrix[row+numToFill][col-numToFill+i] = numToFill +1;
//                 countOfcells--;
//             }
//         }
//         catch(err) {
//             //todo;
//         }
//         try {
//             for (let i = 0; i < 2*numToFill-1 ; i++) {
//                 matrix[row-numToFill +i][col+numToFill] = numToFill+1;
//                 countOfcells--;
//             }
//         }
//         catch(err) {
//             //todo;
//         }
//         try {
//             for (let i = 0; i < 2*numToFill-1 ; i++) {
//                 matrix[row-numToFill +i][col-numToFill] = numToFill +1;
//                 countOfcells--;
//             }
//         }
//         catch(err) {
//             //todo;
//         }
//         numToFill++;
//     }
//
//     print(matrix);
//     function print(matrix) {
//         for (let i = 0; i < matrix.length ; i++) {
//             console.log(matrix[i].join(" "));
//         }
//     }
// }
// orbit([3, 3, 0, 0]);