function ancientVsMemory(arr) {

    let input = arr.join(" ");
    let names = [];

    let regex = /32656 19759 32763 0 ([0-9]+) 0/;
    let exec;

    while ((exec = regex.exec(input)) !== null) {

        let count = Number(exec[1]);
        let innerPattern = new RegExp('32656 19759 32763 0 ' + count + ' 0 ((\\d+ ){' + count + '})');
        let match = innerPattern.exec(input);
        names.push(match[1]);
        input = input.replace(match[0], "");
    }

    for (let name of names) {
        console.log(convertToName(name));
    }

    function convertToName(str) {
        let name = "";
        let arrLetters = str.split(" ");
        for (let letter of arrLetters) {
            name += String.fromCharCode(Number(letter));
        }
        return name;
    }
}

ancientVsMemory(["32656 19759 32763 0 5 0 80 101 115 104 111 0 0 0 0 0 0 0 0 0 0 0 0",
    "0 32656 19759 32763 0 7 0 83 111 102 116 117 110 105 0 0 0 0 0 0 0 0"]);

