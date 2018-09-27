function rotateArray(input) {
    let step = input[input.length-1];
    input.pop();
    let inputArr = input;
    let newArr = [];

    for (let i = 0; i < inputArr.length ; i++) {
        let currElement = inputArr[i];
        let nextPosition = (i + step)%inputArr.length;
        newArr[nextPosition] = currElement;
    }
    console.log(newArr.join(" "));
}

rotateArray(["Banana","Orange","Coconut","Apple",15]);
rotateArray(["1","2","3","4",2]);




