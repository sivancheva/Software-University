function spiceMustFlow(input) {
    let startAmount = +input;
    let days = 0;
    let minedSpiceTotal = 0;

    while (true) {
        if (startAmount <100) {
            break;
        }
        minedSpiceTotal += startAmount;
        minedSpiceTotal -= 26;
        startAmount -= 10;
        days++;
    }

    minedSpiceTotal = minedSpiceTotal > 26 ? minedSpiceTotal-26 : 0 ;
    console.log(`${days}\n${minedSpiceTotal}`);
}

spiceMustFlow("450");