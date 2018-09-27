function negPosNums(input) {

    let result = [];

    for (let num of input) {
        if (Number(num)< 0) {
            result.unshift(num);
        }else{
            result.push(Number(num))
        }
    }
    console.log(result.join("\n"));
}

negPosNums([3, -2, 0, -1]);