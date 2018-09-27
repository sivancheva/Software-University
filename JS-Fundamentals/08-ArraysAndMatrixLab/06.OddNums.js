function oddNums(input) {

    console.log(input
                .filter((num,i) => i % 2 !== 0)
                .map(num => num * 2)
                .reverse());
}

oddNums([3, 0, 10, 4, 7, 3]);