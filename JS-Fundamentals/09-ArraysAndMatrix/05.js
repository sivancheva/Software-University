function filterIncreasingSu(input) {

    let arr = input;
    let maxElement = arr[0];
    let result = [maxElement];

    for (let i = 1; i < arr.length; i++) {

        let currElement = arr[i];
        if (currElement>= maxElement) {
            result.push(currElement);
            maxElement = currElement;
        }
    }
    console.log(result.join("\n"));
}
filterIncreasingSu([1,3,8,4,10,12,3,2,24]);
filterIncreasingSu([1,2,3,4]);
filterIncreasingSu([20,3,8,4,10,12,3]);
