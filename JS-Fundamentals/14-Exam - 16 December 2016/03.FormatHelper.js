function formatHelper(arr) {
    let input = arr[0];

    input = input.replace(/([.,!?:;])\s*/g, (match, g1) => `${g1} `);
    input = input.replace(/\s+([.,!?:;])/g, (match, g1) => g1.trim());
    input = input.replace(/\.\s*\.\s*\.\s*!/g, (match, g1) => '...!');
    input = input.replace(/\.\s*([\d]+)/g, (match, g1) => `.${g1}`);
    input = input.replace(/\"([^"]+)\"/g, (match, g1) => `"${g1.trim()}"`);
    console.log(input);
}

formatHelper(['Terribly formatted text      .  With chaotic spacings." Terrible quoting   "! Also this date is pretty confusing : 20   .   12.  16 .']);

//
// function formatHelper(arr) {
//     let input = arr[0];
//     let regexPunktuacija = /\s*(["\.,!\?:;])\s*/g;
//     if (regexPunktuacija.test(input)) {
//         let matches = input.match(regexPunktuacija);
//         for (let match of matches) {
//             let matchToReplace  = match.trim();
//             input = input.replace(match,matchToReplace + " ");
//         }
//     }
//     console.log(input);
//
//     let regexDates = /([\d]+)\s*\.{1}\s*/g;
//     if (regexDates.test(input)) {
//         let matchedDates = input.match(regexDates);
//         for (let match of matchedDates) {
//             let modifiedMatch = match.split(".").join('').trim();
//             input = input.replace(match, modifiedMatch + '.');
//         }
//     }
//     console.log(input);
//     let regexTo4ki = /\s*[\.\s]+\s*!\s*/g;
//     if (regexTo4ki.test(input)) {
//         let matchedTo4ki = input.match(regexTo4ki);
//         for (let match of matchedTo4ki) {
//             let modifiedTo4ki = match.split(' ').join('');
//             input = input.replace(match, modifiedTo4ki);
//         }
//     }
//     console.log(input);
//     let regexKavi4ki = /"(\s*[\s\S]+\s*)"/g;
//     if (regexKavi4ki.test(input)) {
//         let execKavi4ki = regexKavi4ki.exec(input);
//         while (execKavi4ki !== null) {
//             let matchToReplace = execKavi4ki[1];
//             input = input.replace(matchToReplace, "\"" + matchToReplace.trim() + "\"");
//             execKavi4ki = regexKavi4ki.exec(input);
//         }
//     }
//
//     console.log(input);
// }