function concatenateAndReverse(input) {

    let str = "";

    for (let obj of input) {
        str = str.concat(obj);
    }
    console.log(str.split("").reverse().join(""));
}

concatenateAndReverse(['I', 'am', 'student']);