function assignProperties(input) {

    let prop1 = input[0];
    let value1 = input[1];
    let prop2 = input[2];
    let value2 = input[3];
    let prop3 = input[4];
    let value3 = input[5];

    let obj = {
        [prop1]: value1,
        [prop2]: value2,
        [prop3]: value3
    };
    return obj;
}

console.log(assignProperties(['name', 'Pesho', 'age', '23', 'gender', 'male']));
