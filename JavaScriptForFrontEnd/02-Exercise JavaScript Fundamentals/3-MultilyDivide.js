// You are given a number N and a number X. Create a JS function that:
// •	Multiplies N * X if X is greater than or equal to N
// •	Divides N / X if N is greater than X
// The input comes as array of strings.

function multiplyOrDivide(input) {
    let n = input[0];
    let x = input[1];

    if(x>=n){
        return n*x;
    }else{
        return n/x;
    }
}

console.log(multiplyOrDivide([144,12]))