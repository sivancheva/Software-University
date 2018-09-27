function sumFirstAndLast(input) {
    return (Number(input[0]) + Number(input[input.length-1]));
}

console.log(sumFirstAndLast(['20', '30', '40']));