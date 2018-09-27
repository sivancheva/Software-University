function censorship(text, arr) {

    for (let i = 0; i < arr.length; i++) {
        let regex = new RegExp(arr[i], "g");
        text = text.replace(regex, "-".repeat(arr[i].length));
    }

    console.log(text);
}

censorship('roses are red, violets are blue are red, violets are blue', [', violets are', 'red']);