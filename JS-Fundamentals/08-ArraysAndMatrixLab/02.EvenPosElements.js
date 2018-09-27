function evenPosEl(input) {
    console.log(input.filter((num, i) => i % 2 === 0).join(" "));
}

evenPosEl(['20', '30', '40']);