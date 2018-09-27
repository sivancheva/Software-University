function distanceOverTime(input) {

    let v1 = Number(input[0]); //km/h
    let v2 = Number(input[1]); //km/h
    let periode = Number(input[2]) * 0.000277777778; //h

    let s1 = periode * v1 * 1000; //in m
    let s2 = periode * v2 * 1000;

    let result = Math.abs(s1-s2);
    console.log(result);
}

distanceOverTime([0, 60, 3600]);