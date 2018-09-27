function galacticElections(arr) {

    let result = {};
    let total =  0;

    for (let obj of arr) {

        let system = obj.system;
        let candidate = obj.candidate;
        let votes = +obj.votes;
        total += votes;

        if (!result.hasOwnProperty(system)) {
            result[system] = {};
            result[system]["totalVotes"] = 0;
        }
        if (!result[system].hasOwnProperty(candidate)){
            result[system][candidate] = 0;
        }
        result[system][candidate] += votes;
        result[system]["totalVotes"] += votes;
    }

    console.log(result);


    for (let system of Object.keys(result)) {

        let orderedCandidates =Object.keys(result[system]).filter(x => x !== "totalVotes").sort((c1,c2) =>{
            return result[system][c2] - result[system][c1];
        });
    }




}


galacticElections([ { system: 'Theta', candidate: 'Flying Shrimp', votes: 10 },
    { system: 'Sigma', candidate: 'Space Cow',     votes: 200 },
    { system: 'Sigma', candidate: 'Flying Shrimp', votes: 120 },
    { system: 'Tau',   candidate: 'Space Cow',     votes: 15 },
    { system: 'Sigma', candidate: 'Space Cow',     votes: 60 },
    { system: 'Tau',   candidate: 'Flying Shrimp', votes: 150 } ]);
