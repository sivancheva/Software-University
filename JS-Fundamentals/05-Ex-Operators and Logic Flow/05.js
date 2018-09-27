function gradToDegree(grads){

    let degree = 0;
    let radians = grads*0.9;
    let modulo = radians%360;

    if (modulo<0) {
        degree = 360+modulo;
    }else{
        degree = modulo
    }
    console.log(degree);
}

