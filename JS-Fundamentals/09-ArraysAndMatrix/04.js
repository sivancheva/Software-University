function rotateArray(input) {
    let step = +input.pop();
    let newArr = [];

    for (let i = 0; i < input.length; i++) {
        let currElement = input[i];
        let nextPosition = (i + step) % input.length;
        newArr[nextPosition] = currElement;
    }
    console.log(newArr.join(" "));
}

rotateArray(["Banana", "Orange", "Coconut", "Apple", 15]);
rotateArray(["1", "2", "3", "4", 2]);




