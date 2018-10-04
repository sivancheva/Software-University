
function printArray(input) {
    let deliminator =  input.pop();
       console.log(input.join(`${deliminator}`));
}

//
// function printArray(input) {
//     let deliminator = input[input.length-1];
//     input.pop();
//
//     console.log(input.join(`${deliminator}`));
// }

printArray(["How about no?","will","Three","Four","Five","_"]);