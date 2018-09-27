function extractText(text) {

    let startIndex = text.indexOf("(");
    let endIndex = text.indexOf(")", startIndex);

    let result = [];

    while (startIndex > -1 && endIndex >-1){
        let searchedStr = text.substring(startIndex+1, endIndex)
        result.push(searchedStr);

        startIndex = text.indexOf("(", endIndex);
        endIndex = text.indexOf(")", startIndex);
    }
    console.log(result.join(", "));
}

extractText('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');