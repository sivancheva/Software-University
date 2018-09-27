function usernames(arr) {

    let userNames = new Set();

    for (let name of arr) {
        userNames.add(name);
    }

    Array.from(userNames.keys()).sort((a, b) => sortSet(a, b)).forEach(x => console.log(x));

    function sortSet(a, b) {
        if (a.length !== b.length) {
            return a.length - b.length;
        } else {
            return a.localeCompare(b);
        }
    }
}

usernames([
    "Ashton",
    "Kutcher",
    "Ariel",
    "Lilly",
    "Keyden",
    "Aizen",
    "Billy",
    "Braston",
])