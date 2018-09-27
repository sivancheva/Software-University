function biggestOfThreeNumbers(input){
    "use strict";
    let inputArr = input.map(Number);
    let maxNum = Math.max.apply(Math, inputArr);
    console.log(maxNum);
}
biggestOfThreeNumbers([5, -2, 7]);
