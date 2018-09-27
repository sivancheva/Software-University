function square(n) {

    let smallerThan4 = false;

    let result = "";

    if (n % 2 === 0) {

        if (n <= 4) {
            smallerThan4 = true;
        }

        let counter = n-1;
        for (let i = 0; i <counter; i++) {

            result +="+" + "-".repeat(n - 2) + "+" + "-".repeat(n - 2) + "+";
            result +="\n";

            if (!smallerThan4) {
                for (let j = 0; j < parseInt(n / 2) - 2; j++) {
                    result += "|" + ".".repeat(n - 2) + "|" + ".".repeat(n - 2) + "|";
                    result += "\n";
                    counter--;
                }
            }
            result.slice(-1);
        }
    }else{
        let counter = n;
        for (let i = 0; i < counter ; i++) {
            result += "+" + "-".repeat(n - 2) + "+" + "-".repeat(n - 2) + "+";
            result +="\n";
            if (!smallerThan4) {
                for (let j = 0; j < parseInt(n / 2) - 1; j++) {
                    result += "|" + ".".repeat(n - 2) + "|" + ".".repeat(n - 2) + "|" ;
                    result += "\n";
                    counter--;
                }
            }
        }
        result.slice(-1);
    }

    console.log(result);

}

square(5);