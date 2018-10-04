function smallestNum(arr) {

    console.log(arr.map((num) => {
        "use strict";
        return +num;
    })
        .sort((a, b) => {
        "use strict";
        return a - b;
    })
        .slice(0, 2));;

}

smallestNum([30, 15, 50, 5]);