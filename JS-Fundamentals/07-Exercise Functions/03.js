function templateFormat(input) {

    let result = "<?xml version=\"1.0\" encoding=\"UTF-8\"?> \n";

    result += "<quiz> \n";
    for (let i = 0; i < input.length; i += 2) {
        result += `\xa0<question> \n \xa0\xa0${input[i]} \n </question>\n`;
        result += `\xa0<answer> \n \xa0\xa0${input[i + 1]} \n </answer> \n`;
    }
    result += "</quiz>";
    return result;
}

console.log(templateFormat(["Dry ice is a frozen form of which gas?",
    "Carbon Dioxide",
    "What is the brightest star in the night sky?",
    "Sirius"]
));