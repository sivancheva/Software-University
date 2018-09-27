function f1Champinship(arr) {

    let result = {};

    for (let line of arr) {

        let [teamName, pilotName, points] = line.split(" -> ");

        if (!result.hasOwnProperty(teamName)) {
            result[teamName] = {};
            result[teamName]["totalScore"] = 0;
        }
        if (!result.hasOwnProperty(teamName).hasOwnProperty(pilotName) && !checkIfPilotAlreadyExists(result, pilotName) && Object.keys(result[teamName]).length < 3) {
            result[teamName][pilotName] = 0;
        }
        if (result.hasOwnProperty(teamName) && result[teamName].hasOwnProperty(pilotName)) {
            result[teamName][pilotName] += Number(points);
            result[teamName]["totalScore"] += +points;
        }
    }

    function checkIfPilotAlreadyExists(obj, pilotName) {
        let exist = false;
        for (let key of Object.keys(obj)) {

            for (let pilot of Object.keys(obj[key])) {

                if (pilot === pilotName) {
                    exist = true;
                    break;
                }
            }
        }
        return exist;
    }

    let orderedTeamsByScore = Object.keys(result).sort((p1, p2) => {
        "use strict";
        return result[p2]["totalScore"] - result[p1]["totalScore"];
    });

    for (let team of orderedTeamsByScore.slice(0,3)) {

        console.log(`${team}: ${result[team]["totalScore"]}`);


        let orderedPilots = Object.keys(result[team]).filter(x => x !== "totalScore").sort((a, b) => {
            "use strict";
            return result[team][b] - result[team][a];
        });

        for (let p of orderedPilots) {
            console.log(`-- ${p} -> ${result[team][p]}`);
        }
    }
  }


f1Champinship(["Ferrari -> Kimi Raikonnen -> 25",
    "Ferrari -> Sebastian Vettel -> 18",
    "Mercedes -> Lewis Hamilton -> 10",
    "Mercedes -> Valteri Bottas -> 8",
    "Red Bull -> Max Verstapen -> 6",
    "Red Bull -> Daniel Ricciardo -> 4"]);
