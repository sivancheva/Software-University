function dna(number){
    "use strict";
    let num = Number(number);
    let letters = "ATCGTTAGGG";
    let index = 0;

    for (let i = 0; i < num; i++) {

        let row = i%4;
        if (index === letters.length) {
            index = 0;
        }
        if (row === 0) {
            console.log(`**${letters[index++]}${letters[index++]}**`);
        }else if(row ===1 || row ===3){
            console.log(`*${letters[index++]}--${letters[index++]}*`);
        }else{
            console.log(`${letters[index++]}----${letters[index++]}`);
        }
    }
}

dna(10);