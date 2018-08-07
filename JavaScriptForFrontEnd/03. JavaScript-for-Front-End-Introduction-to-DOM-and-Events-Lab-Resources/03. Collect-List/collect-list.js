function extractText() {

    let items = document.getElementsByTagName("li");
    let result = document.getElementById("result");

    for(let element of items){
        result.value += element.textContent +"\n";
    }
}