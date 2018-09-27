function arenaTier(input) {

    let gladiators = new Map();

    for (let line of input) {

        if (line === "Ave Cesar") {
            break;
        }
        if (line.includes("->")) {

            let [gladiatorName, technique, skill] = line.split("->").map(x=>x.trim());

            if (!gladiators.has(gladiatorName)) {
                gladiators.set(gladiatorName, new Map());
            }
            if (!gladiators.get(gladiatorName).has(technique)) {
                gladiators.get(gladiatorName).set(technique, 0);
            }
            if (gladiators.get(gladiatorName).get(technique) < +skill) {
                gladiators.get(gladiatorName).set(technique, +skill);
            }
        }

        if (line.includes("vs")) {

            let [gladiator1, gladiator2] = line.split("vs").map(x=>x.trim());


        }
    }
    console.log();
}

arenaTier(["Pesho -> BattleCry -> 400",
     "Gosho -> PowerPunch -> 300",
    "Stamat -> Duck -> 200",
    "Stamat -> Tiger -> 250",
    "Ave Cesar" ]);