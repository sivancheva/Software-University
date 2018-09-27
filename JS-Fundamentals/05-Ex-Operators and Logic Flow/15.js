function pointInRechtangle(input) {

    let x = Number(input[0]);
    let y = Number(input[1]);
    let xMmin = Number(input[2]);
    let xMax = Number(input[3]);
    let yMin = Number(input[4]);
    let yMax = Number(input[5]);

    if(x>=xMmin && x<=xMax && y>=yMin && y<=yMax){
        return "inside";
    }else{
        return "outside";
    }
}

console.log(pointInRechtangle([8,-1,2,12,-3,3]));
console.log(pointInRechtangle([12.5,-1,2,12,-3,3]));

