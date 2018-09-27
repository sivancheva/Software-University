function triangleOf$(input){
    "use strict";
    let n = Number(input);

    for (let i = 1; i <= n; i++) {
        console.log(("$").repeat(i));
    }
}
triangleOf$(6);