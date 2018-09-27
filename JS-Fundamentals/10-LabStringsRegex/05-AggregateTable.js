function aggregateTable(arr) {

    let towns = [];
    let sum = 0;

    for (let line of arr) {
        line = line.split("|").filter(x=>x!== "").map(t => t.trim());
        towns.push(line[0]);
        sum += +line[1];
    }

    console.log(towns.join(", "));
    console.log(sum);
}

aggregateTable(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']);