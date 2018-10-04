function solve(input){

    let num = input;
    while(true){
        let average = calcAverage(num);
        if(average > 5){
            console.log(num);
            return;
        }else{
            num += "9";
        }
    }
    function calcAverage(number) {
        let sum = 0;
        for (let i = 0; i < number.length; i++) {
            sum += +number[i];
        }
        return sum/number.length;
    }
}

solve("101");