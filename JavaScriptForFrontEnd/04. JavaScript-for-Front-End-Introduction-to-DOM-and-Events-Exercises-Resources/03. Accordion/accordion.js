function toggle() {
    let spanButton = document.getElementsByClassName("button")[0];
    let spanButtonText = document.getElementsByClassName("button")[0].textContent;
    //console.log(spanButtonText);
    //console.dir(spanButton);
    let divExtra = document.getElementById("extra");
    //console.dir(divExtra);

    if(spanButtonText === "More"){
        document.getElementsByClassName("button")[0].textContent = "Less";
        divExtra.style.display = "block";
    }else{
        document.getElementsByClassName("button")[0].textContent  = "More";
        divExtra.style.display = "none";
    }

}