function matchAllWords(str) {

    let regex = /\w+/g;
    let matches = str.match(regex);
    console.log(matches.join("|"));
}

matchAllWords('A Regular Expression needs to have the global flag in order to match all occurrences in the text');
