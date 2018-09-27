function extractTheLinks(input) {
    let regex = /(www\.)([A-Za-z0-9-]+)(\.[a-z]+)+/g;

    let validLinks = [];

    for (let i = 0; i < input.length; i++) {

        let currElement = input[i];
        let link = currElement.match(regex);
        if (link !== null) {
            validLinks.push(link);
        }
    }
    console.log(validLinks.join("\n"));
}

extractTheLinks(["www.6ustASite.bg"]);