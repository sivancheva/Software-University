function deleteByEmail() {

    let mailToDelete = document.getElementsByName('email')["0"].value;
    let result = document.getElementById("result");

    let tableCustomers = document.getElementById("customers");
    let tableCustomersBody = document.getElementById("customers").children["0"];
    let tableBodyChildren = document.getElementById("customers").children["0"].children; //KOLEKCIJA OT VSI4KI REDOVE V TABLICATA

    //console.dir(tableBodyChildren);

    for (let i=1; i < tableBodyChildren.length; i++) {
        let currRow = tableBodyChildren[i]; // chrez console.dir inamirame reda ot tablicata
        let currMail = tableBodyChildren[i].children[1].innerHTML; // chrez console.dir namirame meila kato text

        if(currMail === mailToDelete){
            tableBodyChildren[i].parentNode.removeChild(tableBodyChildren[i]); //otidi na i-ti red v tablicata, ka4i se na ba6ta mu
            //i mu kaji da mahne svoeto dete (tableBodyChildren[i]- koeto e i-tija red v tablicata)
            document.getElementsByName('email')["0"].value = "";
            result.innerHTML = "DELETED.";
        }else{
            result.style.textTransform = "none";
            result.innerHTML = "Not found.";

        }

    }

}