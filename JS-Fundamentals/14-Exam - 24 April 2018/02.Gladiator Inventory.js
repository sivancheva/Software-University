function gladiatorInventory(arr) {

    let inventory = arr[0].split(" ").map(x=>x.trim());


    for (let line of arr.slice(1)) {
        if (line === "Fight!") {
           break;
        }
        let commandArr = line.split(" ").map(x=>x.trim());
        let command = commandArr[0];
        let equipment = commandArr.pop();

        if (command.startsWith("Buy")) {
            buy(inventory, equipment);
        }else if(command.startsWith("Trash")){
            trash(inventory, equipment);
        }else if(command.startsWith("Repair")){
            repair(inventory, equipment);
            inventory.push(equipment);
        }else if(command.startsWith("Upgrade")){
            let [item, upgr] = equipment.split("-").map(x=>x.trim());
           upgrade(inventory, item, upgr);
        }
    }

    console.log(inventory.join(" "));

    function buy(arr, equipment) {
        if (!arr.includes(equipment)) {
            return arr.push(equipment);
        }
    }

    function trash(arr, equipment) {
        if (arr.includes(equipment)) {
            arr =  arr.splice(arr.indexOf(equipment),1);
            return arr;
        }
    }

    function repair(arr, equipment) {

        if (arr.includes(equipment)) {
            let index = arr.indexOf(equipment);
            arr =  arr.splice(arr.indexOf(equipment),1);

            return arr;
        }
    }

    function upgrade(arr, equipment, upgr) {
        if (arr.includes(equipment)){

            let upgradeToAdd = `${equipment}:${upgr}`;
            arr = arr.splice(arr.indexOf(equipment)+1, 0, upgradeToAdd );
            return arr;
        }
    }
}

gladiatorInventory(["SWORD Shield Spear",
    "Buy Bag",
    "Trash Shield",
    "Repair Spear",
    "Upgrade SWORD-Steel",
    "Fight!" ]);