function kompot(arr) {
    let peachKg = 0;
    let plumKg = 0;
    let cherryKg = 0;
    let fruitsForRakia = 0;

    for (let line of arr) {

        let [fruit, kg] = line.split(/\s+/).map(x => x.trim());

        // let [fruit, kg] = line.trim().replace(/\s+/g, " ").split(" ").map(x => x.trim());
        //
        // или
        //
        // let [fruit, kg] = line.split(/\s+/).map(x => x.trim());
        //
        // Между другито, мапа ти е излишен за трим, понеже е сплитнато по интервали и там вече няма, затова и
        //
        // let [fruit, kg] = line.split(/\s+/) ще ти даде 100%

        switch (fruit.toLowerCase()) {
            case "peach":
                peachKg += +kg;
                break;
            case "plum":
                plumKg += +kg;
                break;
            case "cherry":
                cherryKg += +kg;
                break;
            default:
                fruitsForRakia += +kg;
                break;
        }
    }
    let cherryCompots = Math.floor((cherryKg*1000/9)/25);
    let peachCompot = Math.floor((peachKg*1000/140)/2.5);
    let plumCompots = Math.floor((plumKg*1000/20)/10);
    let rakiqLtr = (fruitsForRakia*0.2);
    console.log(`Cherry kompots: ${cherryCompots}\nPeach kompots: ${peachCompot}\nPlum kompots: ${plumCompots}\nRakiya liters: ${rakiqLtr.toFixed(2)}`);
}

kompot(['cherry     1.2   ',
    'peach 2.2',
    'plum 5.2',
    'peach 0.1',
    'cherry 0.2',
    'cherry 5.0',
    'plum 10',
    'cherry 20.0',
    'papaya 20']
);