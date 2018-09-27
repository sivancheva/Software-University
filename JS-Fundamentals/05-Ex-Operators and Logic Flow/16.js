function odd1ToN(input) {
    let n = Number(input);

    for (let i = 1; i <=n ; i++) {
        if (i%2 != 0) {
            console.log(i);
        }

    }
}

odd1ToN(5)