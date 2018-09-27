function countWords(arr) {

    let result = new Map();

    let inputArr = arr.join(" ")
        .split(/[^\w]+/)
        .filter(x=>x !== "")
        .map(w=>w.toLowerCase());

    for (let word of inputArr) {

        if (!result.has(word)) {
            result.set(word, 0);
        }

        result.set(word, result.get(word) +1);
    }
    let sortedKeys = Array.from(result.keys()).sort();


    for (let word of sortedKeys) {

        console.log(`'${word}' -> ${result.get(word)} times`);
    }
}

countWords(["Far too slow, you're far too slow."]);