function smallestTwoNums(input) {
    console.log(input.map(x => Number(x)).sort((a, b) => a - b).slice(0, 2));
}
smallestTwoNums([3, 0, 10, 4, 7, 3]);