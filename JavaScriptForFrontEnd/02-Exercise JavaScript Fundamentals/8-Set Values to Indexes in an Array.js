function setValueInArray(input) {
    let lengthOfArray = Number(input[0]); //Parse
    let array = new Array(lengthOfArray).fill(0);

    for(let i = 1; i<input.length; i++){
        let indexValuePairString = input[i];
        let indexValueArray = indexValuePairString.split(' ');
        let index = indexValueArray[0];
        let value = indexValueArray[2];
        array[index]= value;
    }
    for(number of array){
        console.log(number);
    }
}

setValueInArray([2,'0 - 5','0 - 6','0 - 7'])

