function calcAreaAndPerimeter(a, b){
    "use strict";
    let sideA = Number(a);
    let sideB = Number(b);
    let p = 2*(sideA+ sideB);
    let area = sideA*sideB;

    console.log(area);
    console.log(p);

}

calcAreaAndPerimeter([2.5, 3.14]);