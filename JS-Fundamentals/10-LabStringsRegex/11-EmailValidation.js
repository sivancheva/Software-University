function emailValidation(input) {

    let regex = /\b[a-zA-Z0-9]+@[a-z]+\.[a-z]+\b/g;
    if (regex.test(input)) {
        console.log("Valid");
    }else{
        console.log("Invalid");
    }
}

emailValidation("valid@email.bg");