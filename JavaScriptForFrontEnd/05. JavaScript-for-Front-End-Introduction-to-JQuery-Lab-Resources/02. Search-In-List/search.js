function search() {
    let searchedText = $("#searchText").val().toLowerCase();
    let towns = $("#towns li");

    //console.dir(searchedText);
    let counter = 0;

    for (let town of towns) {
        let currentTown = town.textContent.toLowerCase();
        //console.dir(town);

        if (currentTown.includes(searchedText)) {
            counter++;
            //town.style.fontWeight = "bold"; // tuk town e normalna promenliva ot JavaScript
            $(town).css("font-weight", "bold") // tuk town e kato jQuery obekt
            $("#searchText").val("");
        } else{
            $(town).css("font-weight", "normal");
        }

    }
    $("#result").text(`${counter} matches found`);

}