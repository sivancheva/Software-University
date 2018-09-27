function formFiller(username,email,phone, text) {

    let regexUsername = /<!([a-zA-Z]+)!>/g;
    let regexEmail =  /<@[a-zA-Z]+@>/g;
    let regexPhone = /<\+[a-zA-Z]+\+>/g;
    for (let i = 0; i < text.length ; i++) {
        text[i] = text[i].replace(regexUsername, username)
            .replace(regexEmail,email)
            .replace(regexPhone,phone);
        console.log(text[i]);
    }
}

formFiller('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']
);