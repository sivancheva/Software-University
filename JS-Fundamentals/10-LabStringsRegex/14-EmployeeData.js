function employeeData(arr) {

    let regex = /^([A-Z][a-zA-Z]*) - ([1-9][0-9]*\.?\d*) - ([a-zA-Z0-9 -]+)$/g;

    let exec;
    let info = [];

    for (let obj of arr) {
        while (exec = regex.exec(obj)) {
            info.push(`Name: ${exec[1]}\nPosition: ${exec[3]}\nSalary: ${exec[2]}`);
        }
    }
    console.log(info.join("\n"));
}

employeeData(['Isacc -   000.0000 - CEO',
    'Ivan - 500 - Employee leader',
    'Peter - 500 - Employee']
);