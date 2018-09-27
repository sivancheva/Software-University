function tresureLocator(input) {

    for (let i = 0; i < input.length; i+=2) {
        let x = input[i];
        let y = input[i+1];
        console.log(checkLocation(x, y));
    }
    function checkLocation(p1,p2) {
        if(p1>=8 && p1<= 9 && p2 >= 0 && p2<= 1){
            return "Tokelau";
        }else if(p1>=1 && p1<= 3 && p2 >= 1 && p2<= 3){
            return "Tuvalu";
        }else if(p1>=5 && p1<= 7 && p2 >= 3 && p2<= 6){
            return "Samoa";
        }else if(p1>=0 && p1<= 2 && p2 >= 6 && p2<= 8){
            return "Tonga";
        }else if(p1>=4 && p1<= 9 && p2 >= 7 && p2<= 8){
            return "Cook";
        }else{
            return "On the bottom of the ocean";
        }

    }
}