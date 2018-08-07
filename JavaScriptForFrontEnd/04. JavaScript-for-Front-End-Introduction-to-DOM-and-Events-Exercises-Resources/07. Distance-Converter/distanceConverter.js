function attachEventsListeners() {
    let inputDistance = Number(document.getElementById("inputDistance").value);
    //console.dir(inputDistance);
    let result = document.getElementById("outputDistance");

    let inputUnits = document.getElementById("inputUnits");
    let outputUnits = document.getElementById("outputUnits");

    let selectedInputUnit = document.getElementById("inputUnits")
        .options[document.getElementById("inputUnits").selectedIndex].value;
    let selectedOutputUnit = outputUnits.options[outputUnits.selectedIndex].value;

    console.dir(selectedInputUnit);
}