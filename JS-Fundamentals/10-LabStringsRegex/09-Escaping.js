function escaping(arr) {

    let result = "<ul>" + "\n";

    for (let obj of arr) {
        let escapedText = `  <li>${escapeHTML(obj)}</li>\n`;
        result = result.concat(escapedText);
    }
    result = result.concat("</ul>\n");

    console.log(result);

    function escapeHTML(str) {
        "use strict";
        str = str.replace(/&/g, "&amp;")
            .replace(/>/g, "&gt;")
            .replace(/</g, "&lt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#39;");
        return str;
    }
}

escaping(['<div style=\"color: red;\">Hello, Red!</div>', '<table><tr><td>Cell 1</td><td>Cell 2</td><tr>']);