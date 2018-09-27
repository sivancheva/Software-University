function captureTheNumbers(input) {
    let regex = /\d+/g;
    let matches = [];

    for (let word of input) {
        if (word.match(regex)) {
            for (let obj of word.match(regex)) {
                matches.push(obj);
            }
        }
    }
    console.log(matches.join(" "));
}

captureTheNumbers(["The300", "What is that?", "I think it’s the 3rd movie.", "Lets watch it at 22:45"]);





