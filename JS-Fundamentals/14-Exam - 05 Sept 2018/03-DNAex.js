function dna(arr) {

    let result = [];
    let regex = /([a-z!@#$?]+)=(\d+)--(\d+)<<([a-z]+)/;
    let exec;

    for (let line of arr) {

        if (line === "Stop!") {
            break;
        }
        if (regex.test(line)) {
            exec = regex.exec(line);
            let nameOfGene = exec[1];
            let nameArray = nameOfGene.split(/[!@#$?]/).filter(x => x !== "");
            nameOfGene = "";
            for (let str of nameArray) {
                nameOfGene += str;
            }
            let lengthOfName = Number(exec[2]);
            let contOfGenes = Number(exec[3]);
            let organism = exec[4];

            if (nameOfGene.length === lengthOfName ) {
                let obj;
                if (result.length === 0 || result.every(e => e.typeOrganism !== organism)) {
                    obj = {
                        name: nameOfGene,
                        length: lengthOfName,
                        countGen: contOfGenes,
                        typeOrganism: organism
                    };
                    result.push(obj);
                }else{
                     for(let i = 0; i < result.length; i++) {
                        if (result[i].typeOrganism === organism) {
                            result[i].countGen += contOfGenes;
                        }
                    }
                }
            }
        }
    }

    result.sort((obj1, obj2) => {
        "use strict";
        return obj2.countGen - obj1.countGen;
    });

    for (let obj of result) {
        console.log(`${obj.typeOrganism} has genome size of ${obj.countGen}`);
    }
}

dna(["!fre?esia#=7--450<<mouse",
    "@pa!rcuba@cteria$=13--351<<mouse",
    "!richel#ia??=8--900<<human",
    "Stop!"
]);
