function validityChecker(input) {

    let x1 = input[0];
    let y1 = input[1];
    let x2 = input[2];
    let y2 = input[3];

    if(checkIfValid(x1,y1,0,0)){
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
    if(checkIfValid(x2,y2,0,0)){
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }
    if(checkIfValid(x1,y1,x2,y2)){
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }

    function checkIfValid(p1x,p1y,p2x, p2y){
        let distance = Math.sqrt(Math.pow((p2x - p1x),2) + Math.pow((p2y - p1y),2));
        if(distance === parseInt(distance, 10)){
            return true;
        }else{
            return false;
        }
    }
}