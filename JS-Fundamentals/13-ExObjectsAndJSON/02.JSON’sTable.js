function JSONtable(inputArr) {

    String.prototype.escapeHTML = function(){ //taka pravim metod
        "use strict";
        return this.replace(/&/g, "&amp;") //.this e stringut, koito  sme  podali na funkcijata
            .replace(/>/g, "&gt;")
            .replace(/</g, "&lt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#39;");
    };

    let result = "<table>\n";
    for (let line of inputArr) {

        result += "\t<tr>\n";

        let obj = JSON.parse(line);
        result += `		<td>${obj.name.escapeHTML()}</td>\n`;
        result += `		<td>${obj.position.escapeHTML()}</td>\n`;
        result += `		<td>${obj.salary}</td>\n`;
        result += "\t<tr>\n";
    }
    result += "</table>";

    console.log(result);

}

JSONtable(['{"name":"Pesho","position":"Promenliva","salary":100000}',
'{"name":"Teo","position":"Lecturer","salary":1000}',
'{"name":"Georgi","position":"Lecturer","salary":1000}']
);