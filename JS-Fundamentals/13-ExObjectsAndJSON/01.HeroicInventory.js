function heroicInventory(arr) {

    let register = [];

    for (let line of arr) {
        let currArr = line.split("/").map(x=>x.trim());
        let name = currArr[0];
        let level = +currArr[1];
        let items = [];

        if (currArr.length > 2) {

            items = currArr[2].split(",").map(x=>x.trim());
        }
        let hero = {
            name: name,
            level: +level,
            items: items
        }

        register.push(hero);
    }
    console.log(JSON.stringify(register));
}

heroicInventory(["Isacc / 25 /dfg  ",
"Derek / 12 / BarrelVest, DestructionSword",
"Hes / 1 / Desolator, Sentinel, Antara"]);