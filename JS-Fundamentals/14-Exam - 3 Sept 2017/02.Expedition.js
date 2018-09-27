function expedition(primaryMatrix, secondaryMatrix, startingCoordinates, start) {


    primaryMatrix = modifyingMatrix(primaryMatrix, secondaryMatrix, startingCoordinates);

    let rowStartEscape = +start[0];
    let colStartEscape = +start[1];

    let currRow = rowStartEscape;
    let curCol = colStartEscape;
    let steps = 1;

    while (true) {

        primaryMatrix[currRow][curCol] = "visited";

        if (checkIfCoordianatesAreValid(primaryMatrix, currRow+1,curCol) && primaryMatrix[currRow+1][curCol] !== "visited" && primaryMatrix[currRow+1][curCol] === 0){
            currRow++;
            steps++;
        }else if(checkIfCoordianatesAreValid(primaryMatrix, currRow-1,curCol) && primaryMatrix[currRow-1][curCol] !== "visited" && primaryMatrix[currRow-1][curCol] === 0){
            currRow--;
            steps++;
        }else if(checkIfCoordianatesAreValid(primaryMatrix, currRow,curCol+1) && primaryMatrix[currRow][curCol+1] !== "visited" && primaryMatrix[currRow][curCol+1] === 0){
            curCol++;
            steps++;

        }else if(checkIfCoordianatesAreValid(primaryMatrix, currRow,curCol-1) && primaryMatrix[currRow][curCol-1] !== "visited" && primaryMatrix[currRow][curCol-1] === 0){
            curCol--;
            steps++;
        }else{
            break;
        }
    }

    console.log(steps);
    if (end(primaryMatrix, currRow, curCol) === "Dead end") {
        console.log(`Dead end ${determineQuadrant(primaryMatrix, currRow, curCol)}`);
    }else{
        console.log(end(primaryMatrix, currRow, curCol));;
    }


    function modifyingMatrix(primaryMatrix, secondaryMatrix, startingCoordinates) {

        for (let line of startingCoordinates) {
            let rowIndex = +line[0];
            let colIndex = +line[1];

            for (let row = 0; row < secondaryMatrix.length; row++) {
                for (let col = 0; col < secondaryMatrix[row].length; col++) {

                    if (checkIfCoordianatesAreValid(primaryMatrix, rowIndex + row, colIndex + col)) {

                        if (secondaryMatrix[row][col] === 1) {
                            primaryMatrix[rowIndex + row][colIndex + col] = Math.abs(primaryMatrix[rowIndex + row][colIndex + col] - 1);
                        }
                    }
                }
            }
        }

        return primaryMatrix;
    }

    function determineQuadrant(matrix, rowIndex, colIndex) {

        let rowsCount = matrix.length;
        let colsCount = matrix[0].length;

        let quadrant = 0;

        if ((rowIndex >= 0 && rowIndex < rowsCount / 2) && (colIndex >= 0 && colIndex < colsCount / 2)) {
            quadrant = 2;
        } else if ((rowIndex >= 0 && rowIndex < rowsCount / 2) && (colIndex >= colsCount / 2 && colIndex < colsCount)) {
            quadrant = 1;
        } else if ((rowIndex >= rowsCount / 2 && rowIndex < rowsCount) && ((colIndex >= 0 && colIndex < colsCount / 2))) {
            quadrant = 3;
        } else if ((rowIndex >= rowsCount / 2 && rowIndex < rowsCount) && (colIndex >= colsCount / 2 && colIndex < colsCount)) {
            quadrant = 4;
        }

        return quadrant;

    }

    function checkIfCoordianatesAreValid(matrix, rowIndex, colIndex) {
        let isValid = false;

        if (rowIndex >= 0 && rowIndex < matrix.length && colIndex >= 0 && colIndex < matrix[rowIndex].length) {
            isValid = true;
        }
        return isValid;

    }

    function end(matrix, rowIndex, colIndex) {

        let end = "Dead end";

        if (rowIndex === matrix.length-1) {
            end = "Bottom";
        }else if(rowIndex === 0){
            end = "Top";
        }else if(colIndex === 0){
            end = "Left";
        }else if(colIndex === matrix[0].length - 1){
            end = "Right";
        }
        return end;
    }
}


expedition([[1, 1, 0, 1],
        [0, 1, 1, 0],
        [0, 0, 1, 0],
        [1, 0, 1, 0]],
    [[0, 0, 1, 0, 1],
        [1, 0, 0, 1, 1],
        [1, 0, 1, 1, 1],
        [1, 0, 1, 0, 1]],
    [[0, 0],
        [2, 1],
        [1, 0]],
    [2, 0]);