function findVariableName(input) {
    let matches = [];
    let regex = /_([a-zA-Z0-9]+)/g;

    let match = regex.exec(input);
    while (match !== null) {
        matches.push(match[1]);
        match = regex.exec(input);
    }
    console.log(matches.join(","));
}

findVariableName("The _id and _age variables are both integers.");