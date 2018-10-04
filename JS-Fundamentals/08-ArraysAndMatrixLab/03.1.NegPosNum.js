function negativePosNum(arr) {
    let result =[];

    arr.map((num)=>{
        "use strict";
        if (num<0) {
        return result.unshift(num);
        }else{
            return result.push(num);
        }
    });
    console.log(result.join(","));
}

negativePosNum([7, -2, 8, 9]);