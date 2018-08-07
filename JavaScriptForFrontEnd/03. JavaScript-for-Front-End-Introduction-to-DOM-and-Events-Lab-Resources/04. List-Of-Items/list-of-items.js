function addItem() {
   let itemToAdd = document.getElementById("newItemText").value;
   let li = document.createElement("li");
   li.appendChild(document.createTextNode(itemToAdd));
   document.getElementById("items").appendChild(li);
   document.getElementById("newItemText").value = "";
}