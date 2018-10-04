function buildAWall(arr) {

    const concretePrice = 195;
    let start = [].concat(arr).map(x => Number(x));
    let days = 0;
    let concreteKbYardByDay = [];
    while (!isBuilt(start)) {

        let concreteCount = 0;
        for (let i = 0; i < start.length; i++) {

            if (start[i] < 30) {
                start[i]++;
                concreteCount++;
            }
        }
        days++;
        concreteKbYardByDay.push(concreteCount * concretePrice);
    }
    console.log(concreteKbYardByDay.join(", "));
    console.log(concreteKbYardByDay.reduce((a, b) => a + b) * 1900 + " pesos");

    function isBuilt(arr) {
        return arr.every(x => x === 30);
    }
}

buildAWall([17, 22, 17, 19, 17]);