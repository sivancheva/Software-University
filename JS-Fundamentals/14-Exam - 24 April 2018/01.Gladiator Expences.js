function gladiatorExpences(lostFights, helmetPrice, swordPrice, shieldPrice, armorPrice) {

    let expenses = 0;

    expenses += Math.floor(lostFights/2)*helmetPrice;
    expenses += Math.floor(lostFights/3)*swordPrice;
    expenses += Math.floor(lostFights/6)*shieldPrice;
    expenses += Math.floor(lostFights/12)*armorPrice;

    console.log(`Gladiator expenses: ${expenses.toFixed(2)} aureus`);

}


gladiatorExpences(7,
2,
3,
4,
5 );
gladiatorExpences(23,
12.50,
21.50,
40,
200 );