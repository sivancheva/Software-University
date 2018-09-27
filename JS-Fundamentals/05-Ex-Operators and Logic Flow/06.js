function compoundInterest(input) {
    "use strict";
    let prinsipalSumP = Number(input[0]);
    let interestRateI = Number(input[1])*0.01; //%
    let periodN = 12/Number(input[2]); //months
    let timespan = Number(input[3]); //totaltimespan months


    let compounedInterest = prinsipalSumP*(Math.pow((1 + (interestRateI/periodN)), periodN*timespan));
    console.log(compounedInterest.toFixed(2));

}

compoundInterest([100000, 5, 12, 25]);