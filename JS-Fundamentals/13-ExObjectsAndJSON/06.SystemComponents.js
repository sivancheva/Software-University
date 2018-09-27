function systemComponents(arr) {

    let db = new Map();

    // “{systemName} | {componentName} | {subcomponentName}”

    for (let line of arr) {

        let [systemName,componentName, subcomponentName] = line.split(/\s*\|\s*/);

        if (!db.has(systemName)) {
            db.set(systemName,new Map());
        }
        if (!db.get(systemName).has(componentName)) {
            db.get(systemName).set(componentName, []);
        }
        db.get(systemName).get(componentName).push(subcomponentName);
    }


    function sortSystems(system1,system2) {
        if (db.get(system2).size !== db.get(system1).size ) {
            return db.get(system2).size -db.get(system1).size;
        }else{
            (system1.toLowerCase()).localeCompare(system2.toLowerCase());
        }
    }
    
    
    function compareComponents(map, component1, component2) {
        return db.get(map).get(component2).length - db.get(map).get(component1).length;
    }
    

    for (let obj of db) {


    }

}
systemComponents([
    "SULS | Main Site | Home Page",
    "SULS | Main Site | Login Page",
    "SULS | Main Site | Register Page",
    "SULS | Judge Site | Login Page",
    "SULS | Judge Site | Submittion Page",
    "Lambda | CoreA | A23",
    "SULS | Digital Site | Login Page",
    "Lambda | CoreB | B24",
    "Lambda | CoreA | A24",
    "Lambda | CoreA | A25",
    "Lambda | CoreC | C4",
    "Indice | Session | Default Storage",
    "Indice | Session | Default Security",
]);