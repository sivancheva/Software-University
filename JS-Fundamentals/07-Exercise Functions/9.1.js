function radioCristals(input) {
    let desiredSize = input[0];
    let cristalsToResize = input.slice(1, input.length);

    let cut = (cristal) => cristal / 4;
    let lap = (cristal) => cristal - cristal * 0.2;
    let grind = (cristal) => cristal - 20;
    let etch = (cristal) => cristal - 2;
    let xRay = (cristal) => cristal + 1;

    for (let i = 0; i < cristalsToResize.length; i++) {
        let action = "";
        let counterCut = 0;
        let currCristal = cristalsToResize[i];
        console.log(`Processing chunk ${currCristal} microns`);


        if (desiredSize - currCristal === 1) {
            counterCut++;
            printTransport(action, counterCut);
            counterCut = 1;
            action = "X-ray";
            currCristal = Math.trunc(xRay(currCristal));
            printFinal(currCristal);
            return;
        }
        if (currCristal-desiredSize ===2) {
            action = "Etch";
            counterCut++;
            currCristal = Math.trunc(etch(currCristal));
            printTransport(action, counterCut);
            printFinal(currCristal);
            return;
        }

        

        while (currCristal > desiredSize) {
            action = "Cut";
            if (cut(currCristal) > desiredSize) {
                counterCut++;
                currCristal = Math.trunc(cut(currCristal));
            }else if (cut(currCristal)=== desiredSize) {
                counterCut++;
                currCristal = Math.trunc(cut(currCristal));
                printTransport(action, counterCut);

            }else if(desiredSize - cut(currCristal) === 1){
                currCristal = cut(currCristal);
                counterCut++;
                printTransport(action, counterCut);
                counterCut = 1;
                action = "X-ray";
                currCristal = Math.trunc(xRay(currCristal));

            }else{
                if (counterCut>0) {
                    printTransport(action,counterCut);
                }
                currCristal = Math.trunc(currCristal);
                counterCut = 0;
                break;
            }
        }
        while (currCristal > desiredSize) {
            action = "Lap";
            if (lap(currCristal) > desiredSize) {
                counterCut++;
                currCristal = Math.trunc(lap(currCristal));
            }else if (lap(currCristal)=== desiredSize) {
                counterCut++;
                currCristal = Math.trunc(lap(currCristal));
                printTransport(action, counterCut);
                printFinal(currCristal);

            }else if(desiredSize - lap(currCristal) ===1){
                currCristal = Math.trunc(lap(currCristal));
                counterCut++;
                printTransport(action, counterCut);
                counterCut = 1;
                action = "X-ray";
                currCristal = Math.trunc(xRay(currCristal));
            }
            else{
                if (counterCut>0) {
                    printTransport(action,counterCut);
                }
                currCristal = Math.trunc(currCristal);
                counterCut = 0;
                break;
            }
        }
        while (currCristal > desiredSize) {
            action = "Grind";
            if (grind(currCristal) > desiredSize) {
                counterCut++;
                currCristal = Math.trunc(grind(currCristal));
            }else if (grind(currCristal)=== desiredSize) {
                counterCut++;
                currCristal = Math.trunc(grind(currCristal));
                printTransport(action, counterCut);

            }else if(desiredSize - grind(currCristal) ===1){
                currCristal = Math.trunc(grind(currCristal));
                counterCut++;
                printTransport(action, counterCut);
                counterCut = 1;
                action = "X-ray";
                currCristal = Math.trunc(xRay(currCristal));
            }
            else{
                if (counterCut>0) {
                    printTransport(action,counterCut);
                }
                currCristal = Math.trunc(currCristal);
                counterCut = 0;
                break;
            }
        }
        while (currCristal > desiredSize) {
            action = "Etch";
            if (etch(currCristal) > desiredSize) {
                counterCut++;
                currCristal = Math.trunc(etch(currCristal));
            }else if (etch(currCristal)=== desiredSize) {
                counterCut++;
                currCristal = Math.trunc(etch(currCristal));
                printTransport(action, counterCut);

            }else if(desiredSize - etch(currCristal) ===1){
                currCristal = Math.trunc(etch(currCristal));
                counterCut++;
                printTransport(action, counterCut);
                counterCut = 1;
                action = "X-ray";
                currCristal = Math.trunc(xRay(currCristal));
                console.log(`${action} x${counterCut}`);
            }
            else{
                if (counterCut>0) {
                    printTransport(action,counterCut);
                }
                currCristal = Math.trunc(currCristal);
                counterCut = 0;
                break;
            }
        }

        printFinal(currCristal);
    }

    function printTransport(action, counter) {
        console.log(`${action} x${counter}\nTransporting and washing`);
    }
    function printFinal(cristalSize) {
        console.log(`Finished crystal ${cristalSize} microns`);
    }
}

radioCristals([15, 55]);