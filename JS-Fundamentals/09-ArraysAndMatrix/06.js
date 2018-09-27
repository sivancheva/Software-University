function sortArray(input){
    "use strict";
    let result = input;

    result.sort(function(a, b) {
        return a.length-b.length || a.toLowerCase().localeCompare(b.toLowerCase());
    })

    console.log(result.join("\n"));

}

//sortArray(["alpha","beta","gamma"]);
sortArray(["test", "Deny", "omen", "Default"])




