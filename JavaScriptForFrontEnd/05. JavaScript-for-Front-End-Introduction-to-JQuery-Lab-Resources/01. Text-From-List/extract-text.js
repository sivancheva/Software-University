function extractText() {
    let items = $("#items li")
        .toArray()
        .map(x=>x.textContent)
        .join(", ");

    $("#result").text(items);
}

