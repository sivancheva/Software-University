function xmlMessanger(input) {

    let mainRegex = /^<message((\s*([a-z]+)="([a-zA-Z0-9\s\.]+)")+)>([\s\S]+)<\/message>$/;

    let from = "";
    let to = "";
    let message = "";

    if (mainRegex.test(input)) {

        let exec = mainRegex.exec(input);
        let messageAtr = exec[1];
        message = exec[exec.length-1].split("\n");

        let atrributesRegex = /\s*([a-z]+)="([a-zA-Z0-9\s\.]+)"/g;

        if (atrributesRegex.test(messageAtr)) {
            let matches = messageAtr.match(atrributesRegex).map(x => x.trim());

            for (let match of matches) {
                let [key, value] = match.split("=");
                value = value.split("").filter(x => x !== "\"").join("");

                if (key === "to") {
                    to = value;
                } else if (key === "from") {
                    from = value;
                }
            }
        }

    } else {
        console.log("Invalid message format");
        return;
    }
    if (to === "" || from === "") {
        console.log("Missing attributes");
        return;
    }
    let messageToAdd = "";
    for (let m of message) {
        messageToAdd += `    <p>${m}</p>\n`;
    }


    console.log("<article>\n" +
        `  <div>From: <span class=\"sender\">${from}</span></div>\n` +
        `  <div>To: <span class=\"recipient\">${to}</span></div>\n` +
        "  <div>\n" +
        `${messageToAdd}` +
        "  </div>\n" +
        "</article>\n");

}

xmlMessanger("<message to=\"Bob\" from=\"Alice\" timestamp=\"1497254114\">Same old, same old</message>");
