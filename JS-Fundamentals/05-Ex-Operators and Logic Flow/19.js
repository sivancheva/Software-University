function quadraticEquation(a,b,c) {


    let d =  Math.pow(b,2) - 4*a*c;

    if (d > 0) {

        let x1 = (-b + Math.sqrt(d)) / (2*a);
        let x2 = (-b - Math.sqrt(d)) / (2*a);

        if (x1 < x2) {
            console.log(x1 + "\n" + x2);
        }else{
            console.log(x2 + "\n" + x1);
        }
    }else if(d === 0){
        console.log(-b / (2*a) );
    }else{
        console.log("No");
    }
}

quadraticEquation(6, 11, -35);