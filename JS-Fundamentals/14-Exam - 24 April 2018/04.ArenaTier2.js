function arenaTier2(arr) {

    let result = {};

    for (let line of arr) {

        if (line.includes("->")) {

            let [gladiatorName, technique, score] = line.split(" -> ");

            if (!result.hasOwnProperty(gladiatorName)) {

                result[gladiatorName] = {};
                result[gladiatorName]["totalScore"] = 0;
            }
            if (!result[gladiatorName].hasOwnProperty(technique)) {
                result[gladiatorName][technique] = +score;

            }
            if (result[gladiatorName].hasOwnProperty(technique)) {

                result[gladiatorName]["totalScore"] += +score;
                if (result[gladiatorName][technique] < +score) {
                    result[gladiatorName]["totalScore"] -= +result[gladiatorName][score];
                    result[gladiatorName]["totalScore"] += +score;
                    result[gladiatorName][technique] = +score;
                }
            }
        }
        if (line.includes("vs")) {
            let [gl1, gl2] = line.split(" vs ");

            if (result.hasOwnProperty(gl1) && result.hasOwnProperty(gl2)) {

                for (let item1 in result[gl1]) {

                    let scoreG1 = result[gl1][item1];
                    let scoreG2 = result[gl2][item1];

                    if (scoreG1 && scoreG2  && item1 !== "totalScore") {
                        if (scoreG1 > scoreG2) {
                            delete result[gl2];
                            break;
                        }else if (scoreG2 > scoreG1) {
                            delete result[gl1];
                            break;
                        }
                    }
                }
            }
        }
        if (line === "Ave Cesar") {
            break;
        }
    }

    let sortedGladiators = Object.keys(result).sort((g1, g2) => {

        if (result[g2]["totalScore"] === result[g1]["totalScore"]) {
            return g1.localeCompare(g2);
        }
        return result[g2]["totalScore"] - result[g1]["totalScore"];
    });

    for (let gladiator of sortedGladiators) {
        console.log(`${gladiator}: ${result[gladiator]["totalScore"]} skill`);

        let sortedTechniques = Object.keys(result[gladiator]).filter(i => i !== "totalScore").sort((item1, item2) => {
            "use strict";
            if (result[gladiator][item1] === result[gladiator][item2]) {
                return item1.localeCompare(item2);
            }
            return result[gladiator][item2] - result[gladiator][item1];
        });

        for (let tech of sortedTechniques) {
            console.log(`- ${tech} <!> ${result[gladiator][tech]}`);
        }
    }
}
// arenaTier2(["Pesho -> BattleCry -> 400",
//     "Gosho -> PowerPunch -> 300",
//     "Stamat -> Duck -> 200",
//     "Stamat -> Tiger -> 250",
//     "Ave Cesar"]);

arenaTier2(["Pesho -> Duck -> 400",
    "Julius -> Shield -> 150",
    "Gladius -> Heal -> 200",
    "Gladius -> Support -> 250",
    "Gladius -> Shield -> 250",
    "Pesho vs Gladius",
    "Gladius vs Julius",
    "Gladius vs Gosho",
    "Ave Cesar"]);