function addItem() {
    let newText = document.getElementById("newText").value; //vzimame texta vuveden v poleto
    let ul = document.getElementById("items"); //vzimame kolekcija ot vsi4ki poleta

    let li = document.createElement("li"); // suzdavame nov element li
    li.textContent = newText;   // kazvame, 4e lito ima text ....
    let span = document.createElement("span"); // suzdavame nov element span
    span.innerHTML = "<a href='#'>[Delete]</a>"; //  kazvame, 4e spana 6te sudurja HTML kato href
    li.appendChild(span); // zaka4ame spana kum li to
    ul.appendChild(li); // zaka4ame lito kum ul a
    document.getElementById("newText").value = ""; // sled zapazvane na teksta ot poleto, no da se izprazni za sledva6to pisane

    span.addEventListener("click", deleteItem); // na spana mu zaka4ame event, da 4aka komanda deleteItem pri klikane
    function deleteItem() {
        let li = this.parentNode; //kogato kliknem spana(za6toto na nego e zaka4en listenera), nie iskame da otidem na li-to, koto durji spana i href-a
        let ul = li.parentNode;
        ul.removeChild(li); // kazvame na ul da iztrie li to
    }

}




