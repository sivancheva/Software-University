function gameOfEpicness(arr, matrix) {

    let kingdoms = {};

    for (let obj of arr) {
        let kingdom = obj.kingdom;
        let general = obj.general;
        let army = obj.army;

        if (!kingdoms.hasOwnProperty(kingdom)) {
            kingdoms[kingdom] = {};
            kingdoms[kingdom]["totalWins"] = 0;
            kingdoms[kingdom]["totalLosses"] = 0;
        }
        if (!kingdoms[kingdom].hasOwnProperty(general)) {
            kingdoms[kingdom][general] = {};
            kingdoms[kingdom][general]["army"] = 0;
            kingdoms[kingdom][general]["wins"] = 0;
            kingdoms[kingdom][general]["losses"] = 0;
        }
        if (kingdoms[kingdom].hasOwnProperty(general)) {
            kingdoms[kingdom][general].army = +army;
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        let attackingKingdom = matrix[i][0];
        let attackingKing = matrix[i][1];
        let defendingKingdom = matrix[i][2];
        let defendingKing = matrix[i][3];

        if (attackingKingdom === defendingKingdom) {
            continue;
        }

        if (kingdoms[attackingKingdom][attackingKing].army > kingdoms[defendingKingdom][defendingKing].army) {
            kingdoms[attackingKingdom][attackingKing].army = Math.floor(kingdoms[attackingKingdom][attackingKing].army +kingdoms[attackingKingdom][attackingKing].army * 0.10);
            kingdoms[defendingKingdom][defendingKing].army = Math.floor(kingdoms[defendingKingdom][defendingKing].army -kingdoms[defendingKingdom][defendingKing].army * 0.10);
            kingdoms[attackingKingdom][attackingKing].wins++;
            kingdoms[defendingKingdom][defendingKing].losses++;
            kingdoms[attackingKingdom].totalWins++;
            kingdoms[defendingKingdom].totalLosses++;

        } else if (kingdoms[attackingKingdom][attackingKing].army < kingdoms[defendingKingdom][defendingKing].army) {
            kingdoms[attackingKingdom][attackingKing].army = Math.floor(kingdoms[attackingKingdom][attackingKing].army-kingdoms[attackingKingdom][attackingKing].army * 0.10);
            kingdoms[defendingKingdom][defendingKing].army = Math.floor(kingdoms[defendingKingdom][defendingKing].army +kingdoms[defendingKingdom][defendingKing].army * 0.10);
            kingdoms[attackingKingdom][attackingKing].losses++;
            kingdoms[defendingKingdom][defendingKing].wins++;
            kingdoms[defendingKingdom].totalWins++;
            kingdoms[attackingKingdom].totalLosses++;
        }
    }

    let orderedKingdoms = Object.keys(kingdoms).sort((k1, k2) => {
        "use strict";
        if (kingdoms[k2].totalWins !== kingdoms[k1].totalWins) {
            return kingdoms[k2].totalWins - kingdoms[k1].totalWins;
        } else if (kingdoms[k1].totalLosses !== kingdoms[k2].totalLosses) {
            return kingdoms[k1].totalLosses - kingdoms[k2].totalLosses
        } else {
            return k1.localeCompare(k2);
        }
    });

    let winner = orderedKingdoms[0];

    console.log("Winner: " + winner);
    let orderedGenerals = Object.keys(kingdoms[winner]).filter(x => x !== "totalWins").filter(x => x !== "totalLosses").sort((g1, g2) => {
        "use strict";
        return kingdoms[winner][g2].army - kingdoms[winner][g1].army;
    });

    for (let gen of orderedGenerals) {
        console.log(`/\\general: ${gen}`);
        console.log(`---army: ${kingdoms[winner][gen].army}`);
        console.log(`---wins: ${kingdoms[winner][gen].wins}`);
        console.log(`---losses: ${kingdoms[winner][gen].losses}`);
    }
}

gameOfEpicness([{kingdom: "Maiden Way", general: "Merek", army: 5000},
        {kingdom: "Maiden Way", general: "Merek", army: 5000},
        {kingdom: "Stonegate", general: "Ulric", army: 4900},
        {kingdom: "Stonegate", general: "Doran", army: 70000},
        {kingdom: "YorkenShire", general: "Quinn", army: 0},
        {kingdom: "YorkenShire", general: "Quinn", army: 2000},
        {kingdom: "Maiden Way", general: "Berinon", army: 100000}],
    [["YorkenShire", "Quinn", "Stonegate", "Ulric"],
        ["Stonegate", "Ulric", "Stonegate", "Doran"],
        ["Stonegate", "Doran", "Maiden Way", "Merek"],
        ["Stonegate", "Ulric", "Maiden Way", "Merek"],
        ["Maiden Way", "Berinon", "Stonegate", "Ulric"]]
);

//
// gameOfEpicness([ { kingdom: "Stonegate", general: "Ulric", army: 5000 },
//         { kingdom: "YorkenShire", general: "Quinn", army: 5000 },
//         { kingdom: "Maiden Way", general: "Berinon", army: 1000 } ],
//     [ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
//         ["Maiden Way", "Berinon", "YorkenShire", "Quinn"] ]
// );