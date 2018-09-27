function minkeDecode(arr) {

    let startIndex = Number(arr[0]);
    let endIndex = Number(arr[1]);
    let wordForChange = arr[2];
    let sentence = arr[3];

    let regexDigits = /\d{3}\.?\d*/g;
    let regexCountry = new RegExp('[A-Z]{1}[a-z]{' + endIndex + ',}[A-Z]{1}');


    let digitsToTown = sentence.match(regexDigits).map(x => Math.ceil(x)).map(x => String.fromCharCode(x)).join("");
    let town = digitsToTown.charAt(0).toUpperCase() + digitsToTown.slice(1);

    let country = sentence.match(regexCountry)[0].toLowerCase();

    country = country.replace(country.substring(startIndex, endIndex+1), "");
    country = country.slice(0, startIndex) + wordForChange + country.slice(startIndex);
    country = country.charAt(0).toUpperCase() + country.slice(1);
    console.log(`${country} => ${town}`);
}

minkeDecode(["3", "5", "gar", "114 sDfia 1, riDl10 confin$4%#ed117 likewise it humanity aTe114.223432 BultoriA - Varnd railLery101 an unpacked as he"]);
minkeDecode(["1", "4","loveni", "SerbiA 67 – sDf1d17ia aTe 1, 108 confin$4%#ed likewise it humanity  Bulg35aria - VarnA railLery1a0s1 111 an unpacked as 109 he"])

