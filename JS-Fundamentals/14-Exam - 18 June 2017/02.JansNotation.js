function JansNotation(arr) {

    let numbers = [];

    for (let obj of arr) {

        if (typeof(obj) === "number") {
            numbers.push(obj);
        }else{
            let operator = obj;

            if (numbers.length >= 2) {
                let num2 = numbers.pop();
                let num1 = numbers.pop();
                let result = eval(+num1 + operator + +num2);
                numbers.push(result);
            }else{
                console.log("Error: not enough operands!");
                return;
            }
        }
    }

    if (numbers.length > 1) {
        console.log("Error: too many operands!");
    }else{
        console.log(numbers[0]);
    }

}

JansNotation([5,
    3,
    4,
    '*',
    '-']

);