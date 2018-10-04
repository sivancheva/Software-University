function spiralmatrix(rows, cols) {
    let n = rows;
    "use strict";
    let start = 1;
    let second = +rows  + 2*(rows-1) + rows - 2;

    let result = [];

    for (let r = 0; r < rows  ; r++) {
        result.push(start++);
    }
    for (let r = 0; r < rows-1 ; r++) {
        for (let c = 0; c < cols-1 ; c++) {
            result.push(second + c);
        }
        result.push(start++);
        second--;
    }
    for (let i = 0; i < n*n; i+= n) {
        console.log(result.splice(0, n).join(" "));
    }
}

spiralmatrix(5,5);