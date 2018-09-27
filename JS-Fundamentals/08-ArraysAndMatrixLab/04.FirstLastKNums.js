function FirstLastKNums(input) {
    let arr = input.map(x => Number(x));
    let count = arr[0];
    arr.shift();
    let firstPart = arr.slice(0, count);
    let secondPart = arr.slice(-count);
    console.log(firstPart + "\n" + secondPart);
}

FirstLastKNums([2,
    7, 8, 9]
);