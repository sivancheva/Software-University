function binaryToDecimal(input) {
    let inputToArray = Array.from(input).reverse();

    let result = 0;
    for (let i = 0; i < inputToArray.length; i++) {

        let currMember = parseInt(inputToArray[i])*(Math.pow(2,i));

        result +=  currMember;
    }
    console.log(result);

}

binaryToDecimal("11110000");