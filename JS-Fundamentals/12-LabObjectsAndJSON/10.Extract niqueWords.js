function extractUniqueWords(inputArr) {


    let set = new Set();

    let arr = inputArr.join("")
        .split(/[^\w]+/)
        .filter(x=>x!=="")
        .map(x=>x.toLowerCase());


    for (let el of arr) {
        set.add(el);
    }

    console.log(Array.from(set).join(", "));
}

extractUniqueWords(["Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Pellentesque quis hendrerit dui."]);