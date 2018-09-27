function tripLength(input) {

    let x1 = input[0];
    let y1 = input[1];
    let x2 = input[2];
    let y2 = input[3];
    let x3 = input[4];
    let y3 = input[5];

    let firstWay = "1->2->3:";
    let secondWay = "1->3->2:";
    let thirdWay = "2->1->3:";

    let dist1 = distance(x1, y1, x2, y2);
    let dist2 = distance(x2, y2, x3, y3);
    let dist3 = distance(x3, y3, x1, y1);

    let bestWay = "";
    let minSumDist = Number.MAX_VALUE;

    for (let i = 0; i < 3; i++) {
        if ((dist1 + dist2) < minSumDist) {
            minSumDist = dist1 + dist2;
            bestWay = firstWay;
        }else if((dist2 + dist3) < minSumDist){
            minSumDist = dist2+dist3;
            bestWay = secondWay;
        }else if((dist3 + dist1) < minSumDist){
            minSumDist = dist3 + dist1;
            bestWay = thirdWay;
        }
    }
    console.log(`${bestWay} ${minSumDist}`);
    function distance(p1x, p1y, p2x, p2y) {
        return Math.sqrt(Math.pow((p2x - p1x), 2) + Math.pow((p2y - p1y), 2));
    }
}

tripLength([-1, -2, 3.5, 0, 0, 2]);