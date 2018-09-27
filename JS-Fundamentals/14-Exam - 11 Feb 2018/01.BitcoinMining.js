function bitcoinMining(arr) {

    const priceGoldGram = 67.51; //lv
    const bitcoinPrice = 11949.16; //lv.

    let currSum = 0;
    let dayWhenBitcoinWasBought = 0;
    let boughtBitcoin = false;
    let contOfBoughtBitcoins = 0;


    for (let i = 0; i < arr.length; i++) {

        if ((i + 1) % 3 === 0) {
            currSum += Number(arr[i]) * 0.7 * priceGoldGram;
        } else {
            currSum += Number(arr[i]) * priceGoldGram; // izkaranoto za denja
        }

        if (!boughtBitcoin) {
            dayWhenBitcoinWasBought++;
        }
        if (currSum >= bitcoinPrice) {
            boughtBitcoin = true;
            contOfBoughtBitcoins += Math.floor(currSum/bitcoinPrice);
            currSum -= Math.floor(currSum/bitcoinPrice)*bitcoinPrice;
        }
    }

    console.log(`Bought bitcoins: ${contOfBoughtBitcoins}`);
    if (contOfBoughtBitcoins > 0) {
        console.log(`Day of the first purchased bitcoin: ${dayWhenBitcoinWasBought}`);
    }
    console.log(`Left money: ${currSum.toFixed(2)} lv.`);
}
bitcoinMining(["100", "200", "300"]);
 bitcoinMining(["13124.15", "504.212", "2511.124"]);
bitcoinMining(["50", "100"]);



