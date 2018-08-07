function addItem() {
    let inputText = document.getElementById("newItemText").value;
    let inputValue = document.getElementById("newItemValue").value;

    let select = document.getElementById("menu");

    let option = document.createElement("option");
    console.dir(option);

    option.text = inputText;
    option.value = inputValue;

    select.appendChild(option);

    document.getElementById("newItemText").value = "";
    document.getElementById("newItemValue").value = "";
}