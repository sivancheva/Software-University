function secretData(input) {

    let regexName = /\*[A-Z]{1}[A-Za-z]*(?=\s|\t|$)/g;
    let regexPhone = /\+[0-9-]{10}(?=\s|\t|$)/g;
    let regexId = /![a-zA-Z0-9]+(?=\s|\t|$)/g;
    let regexSecretName = /_[a-zA-Z0-9]+(?=\s|\t|$)/g;

    let result = "";

    for (let i = 0; i < input.length; i++) {
        result = input[i];
        let currentSentence = input[i].split(" ");

        for (let word of currentSentence) {
            let replaceStr = "";
            let match = [];
            let matchFound = false;

            if (regexName.test(word)) {
                match = word.match(regexName);
                replaceStr = "|".repeat(match[0].length);
                matchFound = true;
            } else if (regexPhone.test(word)) {
                match = word.match(regexPhone);
                replaceStr = "|".repeat(match[0].length);
                matchFound = true;
            } else if (regexId.test(word)) {
                match = word.match(regexId);
                replaceStr = "|".repeat(match[0].length);
                matchFound = true;
            } else if (regexSecretName.test(word)) {
                match = word.match(regexSecretName);
                replaceStr = "|".repeat(match[0].length);
                matchFound = true;
            }
            if (matchFound) {
                result = result.replace(match[0], replaceStr);
            }
        }
        console.log(result);
    }
}

secretData(["Agent*I"]);
//
// secretData(["Agent *Ivankov was in the room when it all happened.", "The person in the room was heavily armed.",
//     "Agent *Ivankov had to act quick in order.",
//     "He picked up his phone and called some unknown number.",
//     "I think it was +555-49-796",
//     "I can't really remember...",
//     "He said something about \"finishing work\" with subject !2491a23BVB34Q and returning to Base _Aurora21",
//     "Then after that he disappeared from my sight.",
//     "As if he vanished in the shadows.",
//     "A moment, shorter than a second, later, I saw the person flying off the top floor.",
//     "I really don't know what happened there.",
//     "This is all I saw, that night."
// ]);













