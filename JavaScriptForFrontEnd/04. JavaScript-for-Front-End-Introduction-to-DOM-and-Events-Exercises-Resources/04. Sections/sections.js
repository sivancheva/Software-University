function create(sentences) {
    let div = document.getElementById("content");

    for(sentence of sentences){
        let newDiv = document.createElement("div");
        let paragraph = document.createElement("p");

        paragraph.textContent = sentence;
        paragraph.style.display = "none";

        newDiv.addEventListener("click", function () {
            newDiv.childNodes["0"].style.display = "block";
        });
        newDiv.appendChild(paragraph);
        div.appendChild(newDiv);
    }
}