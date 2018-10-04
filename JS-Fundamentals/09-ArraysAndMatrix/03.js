function addRemoveElementsFromArr(input) {
    let counter = 1;
    let arr = [];

    for (let i = 0; i < input.length; i++) {
        let command = input[i];
        switch (command) {

            case "add":
                arr.push(counter);
                counter++;
                break;

            case "remove":
                arr.pop();
                counter++;
                break;
        }
    }
    arr.length === 0 ? console.log("Empty") : console.log(arr.join("\n"));
}

addRemoveElementsFromArr(["add","add","add","add"]);
//addRemoveElementsFromArr(["add","add","remove","add","add"]);
addRemoveElementsFromArr(["remove", "remove", "remove"]);