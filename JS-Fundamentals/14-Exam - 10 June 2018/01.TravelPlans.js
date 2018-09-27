function travelPlans(arr) {

    let specialized = [];
    let average = [];
    let clumsy = [];

    for (let line of arr) {
        let [profession, gold] = line.split(" : ");

        switch (profession) {
            case "Programming":
            case "Hardware maintenance":
            case "Cooking":
            case "Translating":
            case "Designing":
                if (gold >= 200) {
                    specialized.push(+gold);
                }
                break;
            case "Driving":
            case "Managing":
            case "Fishing":
            case "Gardening":
                average.push(+gold);
                break;
            case "Singing":
            case "Accounting":
            case "Teaching":
            case "Exam-Making":
            case "Acting":
            case "Writing":
            case "Lecturing":
            case "Modeling":
            case "Nursing":
                clumsy.push(+gold);
                break;
        }
    }
        specialized = specialized.map(num => num - num * 0.2);

    for (let i = 0; i < clumsy.length ; i++) {

        if ((i+1)%2 === 0) {
            clumsy[i] = clumsy[i]-clumsy[i]*0.05;
        }else if ((i+1)%3 === 0) {
            clumsy[i] = clumsy[i]*0.1;
        }
    }

    let total = 0;
    if (specialized.length > 0) {
        total += specialized.reduce((a, b) => a + b);
    }
    if (average.length > 0) {
        total +=average.reduce((a, b) => a + b);
    }
    if (clumsy.length > 0) {
        total += clumsy.reduce((a, b) => a + b);
    }


    for (let i = 0; i < specialized.length ; i++) {
        if ((i+1) % 2 === 0) {
            total += 200;
        }
    }

    let difference = Math.abs(1000-total);
    console.log(`Final sum: ${total.toFixed(2)}`);
    if (total <= 1000) {
        console.log(`Mariyka need to earn ${difference.toFixed(2)} gold more to continue in the next task.`);
    }else{
        console.log(`Mariyka earned ${difference.toFixed(2)} gold more.`);
    }
}

travelPlans(["Programming : 500", "Driving : 243", "Singing : 100", "Cooking : 199"]);
travelPlans(["Programming : 500", "Driving : 243.55", "Acting : 200", "Singing : 100", "Cooking : 199","Hardware maintenance : 800", "Gardening : 700", "Programming : 500"]);

