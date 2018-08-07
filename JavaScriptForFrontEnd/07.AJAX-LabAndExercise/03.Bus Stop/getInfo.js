function getInfo() {
    let bus = $("#stopId").val();
    let url = `https://judgetests.firebaseio.com/businfo/${bus}.json `;

    $.ajax({
        url: url,
        success: getBusInfo,
        error: error
    })

    function getBusInfo(res) {
        $("#stopName").empty();
        $("#buses").empty();

        $("#stopName").append(res.name);
        let busesInfo = res.buses;

        var arrayBussesInfo = Object.entries(busesInfo);

        for (let bus of arrayBussesInfo){
            let busNumber = bus["0"];
            let minutes = bus[1];
            $("#buses").append(`<li> Bus ${busNumber} arrives in ${minutes} minutes</li>`);
        }
    }

    function error(err) {
        $("#stopName").append("Error");
    }
}