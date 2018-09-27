function rounding(input){
    let num = Number(input[0]);
    let precisious = Number(input[1]);

    if (precisious > 15) {
        precisious = 15;
    }
    let roundedNum = num.toFixed(precisious);

    console.log(parseFloat(roundedNum));
}

rounding([3.1415926535897932384626433832795, 2]);