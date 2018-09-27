function capitalizeWords(input) {

    let words = input.split(" ");

    let result = [];

    for (let word of words) {
        let modifiedWord = "";

        let firstLetter = word[0].toUpperCase();
        let restOfTheWord = word.slice(1, word.length).toLowerCase();
        modifiedWord = firstLetter+restOfTheWord;
        result.push(modifiedWord);
    }
    console.log(result.join(" "));
}

capitalizeWords("Was that Easy? tRY thIs onE for SiZe!");