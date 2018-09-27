function LastKNumsSeq(n,k) {

    let sequence = [1];

    for (let i = 1; i < n ; i++) {

        let start = 0;
        if((i-k)> 0){
            start = i-k;
        }
        let sum = sequence.slice(start, i).reduce((a,b) => a+b);
        sequence.push(sum);
    }
    console.log(sequence);
}

LastKNumsSeq(8, 2);