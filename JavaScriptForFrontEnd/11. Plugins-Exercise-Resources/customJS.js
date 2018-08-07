// function openTwitter() {
//     window.open("https://twitter.com/login");
// }
//
// function openGoogle() {
//     window.open("https://www.google.bg/");
// }

$('.dropify').dropify({
});

function redirectToTwitter() {
    swal({
            title: "Leave this site?",
            text: "If you click 'OK' will be redirected to https://twitter.com/login",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-danger",
            confirmButtonText: "OK",
            cancelButtonText: "Cancel",
            closeOnConfirm: false,
            closeOnCancel: false
        },
        function (isConfirm) {
            if (isConfirm) {
                window.open("https://twitter.com/login");
            }else{
                swal("Thanks for staying at our page", " ", "success")
            }
        });

}
function redirectToGoogle() {
    swal({
            title: "Leave this site?",
            text: "If you click 'OK' will be redirected to https://google.com",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-danger",
            confirmButtonText: "OK",
            cancelButtonText: "Cancel",
            closeOnConfirm: false,
            closeOnCancel: false
        },
        function (isConfirm) {
            if (isConfirm) {
                window.open("https://google.com");
            }else{
                swal("Thanks for staying at our page", " ", "success")
            }
        });
}
function submit() {
    $(':input').val('');
    $('.dropify-clear').click();
        swal("Good job!", "You are registered", "success");
}


