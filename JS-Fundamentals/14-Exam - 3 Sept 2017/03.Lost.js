function lost(str1, str2) {

    let messageRegex = new RegExp(str1+ "(.*\\n*)" + str1, "g");
    let messageMatch = messageRegex.exec(str2);
    let message = messageMatch[1];

    let northRegex = /north\D*(\d{2})[^,]*,\D*(\d{6})/gi;
    let northMatch = str2.toLowerCase().match(northRegex);
    let northExec = northRegex.exec(northMatch[northMatch.length-1]);
    let northCoordinates = northExec[1] + "." + northExec[2] + " N";

    let eastRegex = /east\D*(\d{2})[^,]*,\D*(\d{6})/gi;
    let eastMatch = str2.toLowerCase().match(eastRegex);
    let eastExec = eastRegex.exec(eastMatch[eastMatch.length-1]);
    let eastCoordinates = eastExec[1] + "." + eastExec[2] + " E";

    console.log(northCoordinates + "\n" + eastCoordinates + "\n" + "Message: " +  message);
}

lost("keyword",
"keyword  let them eat cake!keywordNORTHEASTNORTH again42,north234567,dsae345East\t23,\n" +
    "    432568");

