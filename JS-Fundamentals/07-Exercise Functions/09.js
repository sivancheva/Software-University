function radioCristals(input) {
    let desiredSize = input[0];
    let cristalsToResize = input.slice(1, input.length);

    let cut = (cristal) => cristal / 4;
    let lap = (cristal) => cristal - cristal * 0.2;
    let grind = (cristal) => cristal - 20;
    let etch = (cristal) => cristal - 2;
    let xRay = (cristal) => cristal + 1;


    for (let i = 0; i < cristalsToResize.length; i++) {

        let currSize = cristalsToResize[i];
        let currAction = "";
        let counterCut = 0;


        while ((currSize >= desiredSize)) {
            currAction = "Cut";
            if (cut(currSize) >= desiredSize || (desiredSize - cut(currSize) === 1)) {
                currSize = cut(currSize);
                counterCut++;
            } else {
                print(currAction, counterCut);
                currSize = Math.trunc(currSize);
                counterCut = 0;
                break;
            }
        }

        while ((currSize >= desiredSize)) {
            if (isFinished(desiredSize, currSize)) {
                break;
            } else {
                currAction = "Lap";
                if (lap(currSize) >= desiredSize || (desiredSize - lap(currSize) === 1)) {
                    currSize = lap(currSize);
                    counterCut++;
                } else {
                    print(currAction, counterCut);
                    currSize = Math.trunc(currSize);
                    counterCut = 0;
                    break;
                }
            }
        }

        while ((currSize >= desiredSize)) {
            if (isFinished(desiredSize, currSize)) {
                break;

            } else {
                currAction = "Grind";
                if (grind(currSize) >= desiredSize || (desiredSize - grind(currSize) === 1)) {
                    currSize = grind(currSize);
                    counterCut++;

                } else {
                    print(currAction, counterCut);
                    currSize = Math.trunc(currSize);
                    counterCut = 0;
                    break;
                }
            }
        }

        while ((currSize >= desiredSize)) {
            if (isFinished(desiredSize, currSize)) {
                break;
            }else{
                currAction = "Etch";
                if (etch(currSize) >= desiredSize || (desiredSize - etch(currSize) === 1)) {
                    currSize = etch(currSize);
                    counterCut++;

                } else {
                    print(currAction, counterCut);
                    currSize = Math.trunc(currSize);
                    counterCut = 0;
                    break;
                }
            }
        }
        if (desiredSize - currSize === 1) {
            currAction = "X-ray";
            currSize = xRay(currSize);
            counterCut++;
            print(currAction, counterCut);
        }
        console.log(`Finished crystal ${currSize} microns`);
    }

    function print(action, counter) {
        console.log(`${action} x${counter} \nTransporting and washing`);
    }

    function isFinished(desiredSize, currSize) {
        if (desiredSize === currSize) {
            return true;
        } else {
            return false;
        }
    }
}

radioCristals([1000, 4000, 8100]);