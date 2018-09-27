function matchMultiplication(str) {

    let regex = /(-?\d+)\s*\*\s*(-?\d+\.?-?\d*)/g;

    let match = str.match(regex);

    for (let i = 0; i < match.length ; i++) {

        let currMatch = match[i];
        let matchArr = currMatch.split("*").filter(x=>x!=="");
        let num1 = +matchArr[0];
        let num2 = +matchArr[1];
        let result = num1*num2;
        str = str.replace(currMatch, result);
    }
    console.log(str);

}

matchMultiplication("My bill: 2*2.50 (beer); 2* 1.20 (kepab); 2  * -0.5 (deposit).");