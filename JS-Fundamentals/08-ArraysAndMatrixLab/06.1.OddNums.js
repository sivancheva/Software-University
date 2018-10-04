function oddNums(arr) {

    console.log(arr = arr.filter((num, index) => {
        return index % 2 !== 0;
    })
        .reverse()
        .map((num) => {
        "use strict";
        return num * 2;
    })
        .join(" "));

}

oddNums([10, 15, 20, 25]);