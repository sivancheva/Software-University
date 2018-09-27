function usernames(arr) {

    let newMails = [];
    for (let email of arr) {
        email = email.split(/[@,\.]/);
        let modifiedMail = email[0] + "." + email[1][0] + email[2][0];
        newMails.push(modifiedMail);
    }
    console.log(newMails.join(", "));
}

usernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);