function multiplicationTable() {

    let n = Number(arguments[0]);

    let result = "<table border='1'>";
    for (let i = 0; i <= n; i++) {

        result += "<tr>";
        if (i === 0) {
            result += "<th>x</th>";
        } else {
            result += `<th>${i}</th>`;
        }
        for (let j = 1; j <= n; j++) {
            if (i === 0) {
                result += `<th>${j}</th>`;
            }else{
                result += `<td>${j}</td>`;
            }
        }
        result += "</tr>" + "\n";
    }
    result += "</table>";

    console.log(result);
}

multiplicationTable(5);

