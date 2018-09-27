function scoreToHTML(inputArr) {

    String.prototype.escapeHTML = function(){ //taka pravim metod
        "use strict";
        return this.replace(/&/g, "&amp;") //.this e stringut, koito  sme  podali na funkcijata
            .replace(/>/g, "&gt;")
            .replace(/</g, "&lt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#39;");
    };

    inputArr = JSON.parse(inputArr);

    let result = "<table>\n";

    result += "  <tr><th>name</th><th>score</th></tr>\n";

    for (let line of inputArr) {
        result += `  <tr><td>${line.name.escapeHTML()}</td><td>${+line.score}</td></tr>\n`;
    }
    result += "</table>";
    console.log(result);

}

scoreToHTML('[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]');


//
// 2.	Score to HTML
// You are given a JSON string representing an array of objects, parse the JSON and create a table using the supplied objects. The table should have 2 columns "name" and "score", each object in the array will also have these keys.
//     Any text elements must also be escaped in order to ensure no dangerous code can be passed.
//     You can either write the HTML escape function yourself or use the one from the Strings and Regular Expressions Lab.
//     The input comes as a single string argument – the array of objects as a JSON.
//     The output should be printed on the console – a table with 2 columns - "name" and "score", containing the values from the objects as rows.
//     Input
// '[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]'
// Output
// <table>
// <tr><th>name</th><th>score</th></tr>
// <tr><td>Pesho</td><td>479</td></tr>
// <tr><td>Gosho</td><td>205</td></tr>
// </table>


