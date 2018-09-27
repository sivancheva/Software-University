function spiralmatrix(rows, cols) {

    let counter = 1;
    let matrix = [[]];
    let colCount = cols;
    let rowCount = rows;

    let currRow = 0;
    let currCol = 0;

    while (counter < rows*cols) {
        
        for (let i = 0; i < colCount; i++) {
            matrix[currRow][i] = counter;
            counter++;
            currCol++;
        }
        currRow++;
        rowCount--;
        for (let i = 0; i < rowCount ; i++) {
            matrix[currRow+i][currCol-1] = counter;
            counter++;
            currRow++;
        }
        currCol--;
        colCount--;
        for (let i = 0; i < colCount  ; i++) {
            matrix[currRow][currCol-1-i] = counter;
            currCol--;
            counter++;
        }
        rowCount--;
        for (let i = 0; i < rowCount ; i++) {
            matrix[currRow-i][currCol-1] = counter;
            currRow--;
        }
        

        console.log(matrix);

    }
}

spiralmatrix(3,3);