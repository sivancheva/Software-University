function hungryProgrammer(food, comands) {

    let mealsEaten = 0;

    for (let line of comands) {

        if (line === "End") {
            break;
        }
        let [command, info, info2] = line.split(" ").filter(x=>x!== "").map(x=>x.trim());

        switch (command.toLowerCase()) {
            case "serve":

                serve(food);
                break;

            case "add":
                add(food, info);
                break;

            case "shift":
                shift(food, +info, +info2);
                break;

            case "eat":
                mealsEaten++;
                eat(food);
                break;

            case "consume":
                console.log("Burp!");
                if (info2 < food.length) {
                    mealsEaten += (+info2+1)-info;
                }else {
                    mealsEaten += food.length-info;
                }
                consume(food, +info, +info2);
                break;
        }
    }

    if (food.length === 0) {
        console.log("The food is gone");
    }else{
        console.log(`Meals left: ${food.join(", ")}`);
    }
    console.log(`Meals eaten: ${mealsEaten}`);


    function serve(arr) {
        if (arr.length>0) {
            console.log(`${arr.pop()} served!`);
        }
        return arr;
    }

    function add(arr, meal) {

        return arr.unshift(meal);
    }

    function shift(arr, startIndex, endIndex) {

        if (+startIndex >= 0 && +endIndex < arr.length) {
            let firstFood = arr[startIndex];
            let secondFood = arr[endIndex];
            arr[startIndex] = secondFood;
            arr[endIndex] = firstFood;
        }
        return arr;
    }

    function eat(arr) {

        if (arr.length > 0) {
            console.log(`${arr.shift()} eaten`);
        }
        return arr;

    }

    function consume(arr, startIndex, endIndex) {

        if (startIndex>= 0  && startIndex < arr.length) {
            arr = arr.splice(startIndex, (endIndex-startIndex+1));
        }

        return arr;
    }
}

hungryProgrammer(['carrots', 'apple', 'beet'],
    ['Consume 0 2',
        'End',]   );