function countWordsInAText(inputArr) {
    let result = {};

    let arr = inputArr.join(" ") //joinvame vsi4ki arr, za da moje da rabotim s edin, a ne da foreachvame
                .split(/[^\w]/)
                .filter(x=> x !== "");

    for (let word of arr) {

        if (!result.hasOwnProperty(word)) {
            result[word] = 0;
        }
        result[word] +=1;
    }

    console.log(JSON.stringify(result));
}
countWordsInAText(["Far", "too", "slow", "you're", "far", "too", "slow."]);