function solve(input){

    let num = input;
    while(true){
        let average = calcAverage(num);
        if(average >= 5){
            console.log(num);
            return;
        }else{
            num += "9";
        }
    }
    function calcAverage(number) {
        let sum = 0;
        let length = number.length;
        for (let i = 0; i < number.length; i++) {
            sum += Number(number[i]);
        }
        return sum/length;
    }
}

solve("5835");