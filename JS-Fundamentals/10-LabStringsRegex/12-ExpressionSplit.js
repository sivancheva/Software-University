function expressionSplit(str) {

    let re = /[\s.();,]+/;
    let arr = str.split(re);

    console.log(arr.join("\n"));
}

expressionSplit('let sum = 4 * 4,b = "wow";');