
function myFunction() {


        let firstName = $("#firstName").val();
        let firstLetter = firstName.charAt(0).toLowerCase();
        let lastName = $("#lastName").val().toLowerCase();
        let branch = $("#branch").val().toLowerCase();
        let company = $("#company").val().toLowerCase();

        $("#resultEmail").attr("placeholder", `${firstLetter}.${lastName}@${branch}-${company}.com`);

}





