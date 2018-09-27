function imperialUnits(input){
   let inchesToConvert = Number(input);
   let feet = Math.trunc(inchesToConvert/12);
   let  inchesRest = inchesToConvert - feet*12;

    console.log(`${feet}'-${inchesRest}"`);
}
imperialUnits(55);