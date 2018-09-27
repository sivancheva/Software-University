function lastMonth(input) {
    let day = Number(input[0]);
    let month = Number(input[1]);
    let year = Number(input[2]);


    var lastDayOfMonth = new Date(year, month-1, 0);
    console.log(lastDayOfMonth.getDate());
}

lastMonth([13, 1, 2004]);