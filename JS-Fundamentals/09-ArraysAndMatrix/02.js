function printEveryNthElement(input) {
    let step = +input.pop();

    for (let i = 0; i < input.length ; i+=step) {
        console.log(input[i]);
    }
}

printEveryNthElement(["dsa","asd","test","tset","2"]);
printEveryNthElement(["5","20","31","4","20", "2"]);

