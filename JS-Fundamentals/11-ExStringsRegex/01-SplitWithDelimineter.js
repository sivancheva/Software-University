function splitStringWithDeliminator(string, delimiter) {

    split(string, delimiter);

    function split(string, delimiter) {
        let splittedElements = string.split(delimiter);
        console.log(splittedElements.join("\n"));
    }
}

splitStringWithDeliminator("http://platform.softuni.bg", ".");


