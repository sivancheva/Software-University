function findOccurrencesOfWordInSentence(sentence, word) {
    let searchedWord = word;

    let regex = new RegExp("\\b" + searchedWord + "\\b", 'gi');
    let matches = [];
    matches = sentence.match(regex);

    if (!Array.isArray(matches) || !matches.length ) {
        console.log(0);
    }else{
        console.log(matches.length);
    }

}

findOccurrencesOfWordInSentence("The waterfall was so high, that the child couldn’t see its peak.","how");