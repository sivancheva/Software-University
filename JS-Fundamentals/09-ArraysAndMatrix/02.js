function printEveryNthElement(input) {
    let step = Number(input[input.length-1]);
    let arr = input;
    arr.pop();

    for (let i = 0; i < arr.length ; i+=step) {
        console.log(arr[i]);
    }
}

printEveryNthElement(["dsa","asd","test","tset","2"]);
printEveryNthElement(["5","20","31","4","20", "2"]);

