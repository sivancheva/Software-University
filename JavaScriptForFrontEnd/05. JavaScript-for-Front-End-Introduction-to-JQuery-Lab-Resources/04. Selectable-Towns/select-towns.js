function attachEvents() {
    let selectedTowns = $("#selectedTowns");


	$("#items").on( "click", function() {
        if (!$(this).is("[data-checked]") || $(this).attr("data-checked") === false ) {
            $(this).attr("data-selected", true);
            $("selectedTowns").add($(this));
        } else if($(this).attr("data-checked") === true){
            $(this).attr("data-selected", false);
            $("selectedTowns").
        }
    });



}