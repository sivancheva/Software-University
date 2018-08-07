function positiveOrNegative(input) {
    let a = input[0];
    let b = input[1];
    let c = input[2];

    if((a>=0 && b >= 0 && c <0)||
        (a>=0 && b < 0 && c >=0)||
        (a<0 && b >= 0 && c >=0) ){

        return "Negative";
    }else{
        return "Positive"
    }
}

console.log(positiveOrNegative([0,3,4]))