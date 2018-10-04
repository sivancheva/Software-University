function rotateArr(arr) {
    let result = [].concat(arr);

    let contOfRotations = +result.pop();

    for (let i = 0; i < contOfRotations; i++) {
        let lastEl = result.pop();
        result.unshift(lastEl);
    }

    console.log(result.join(" "));
}

rotateArr(["1", "2", "3", "4", 2]);