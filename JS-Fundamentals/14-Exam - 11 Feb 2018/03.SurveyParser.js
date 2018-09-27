function surveyParser(input) {

    let regexSVG = /<svg>(.*)<\/svg>/;

    if (regexSVG.test(input)) {
        let insideSVG = regexSVG.exec(input)[1];
        let regexCat = /<cat>(.*)<\/cat>\s*<cat>(.*)<\/cat>/;

        if (regexCat.test(insideSVG)) {
            let insideCatFirst = regexCat.exec(insideSVG)[1];
            let insideCatSecond = regexCat.exec(insideSVG)[2];

            let regexFirstCat = /<text>.*\[(.*)\].*\/text>/;
            let regexSecondCat = /<g><val>(\d+)<\/val>(\d+)<\/g>/g;

            if (regexFirstCat.test(insideCatFirst) && regexSecondCat.test(insideCatSecond)) {

                let surveyLabel = regexFirstCat.exec(insideCatFirst)[1];

                let valuesAr = insideCatSecond.match(regexSecondCat);

                let sumVotes = 0;
                let sumValues = 0;

                for (let i = 0; i < valuesAr.length ; i++) {

                    let exec = /<g><val>(\d+)<\/val>(\d+)<\/g>/.exec( valuesAr[i]);
                    let values  = +exec[1];
                    let votes = +exec[2];
                    sumVotes += votes;
                    sumValues += votes*values;
                }

                console.log(`${surveyLabel}: ${Math.round((sumValues/sumVotes) * 100) / 100}`);

            }else {
                console.log("Invalid format");
            }
        }else{
            console.log("Invalid format");
        }
    }else{
        console.log("No survey found");
    }
}

surveyParser("<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>")
// surveyParser("<svg><cat><text>How do you rate the special menu? [Food - Special]</text></cat> <cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>");
// surveyParser("<p>How do you suggest we improve our service?</p><p>More tacos.</p><p>It's great, don't mess with it!</p><p>I'd like to have the option for delivery</p>")
// surveyParser("<svg><cat><text>Which is your favourite meal from our selection?</text></cat><cat><g><val>Fish</val>15</g><g><val>Prawns</val>31</g><g><val>Crab Langoon</val>12</g><g><val>Calamari</val>17</g></cat></svg>")