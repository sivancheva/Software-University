function moviePrice(){
    "use strict";
    let movieTitle = (arguments[0][0]).toLowerCase();
    let dayOfTheWeek = arguments[0][1].toLowerCase();

    if (movieTitle === "the godfather") {
        switch (dayOfTheWeek) {
            case "monday": return "12";
            case "tuesday": return "10";
            case "wednesday": return "15";
            case "thursday": return "12.5";
            case "friday": return "15";
            case "saturday": return "25";
            case "sunday": return "30";
            default: return "error;"
        }
    }else if (movieTitle === "schindler's list") {
        switch (dayOfTheWeek) {
            case "monday": return "8.5";
            case "tuesday": return "8.5";
            case "wednesday": return "8.5";
            case "thursday": return "8.5";
            case "friday": return "8.5";
            case "saturday": return "15";
            case "sunday": return "15";
            default: return "error;"
        }
    }else if (movieTitle === "casablanca") {
        switch (dayOfTheWeek) {
            case "monday": return "8";
            case "tuesday": return "8";
            case "wednesday": return "8";
            case "thursday": return "8";
            case "friday": return "8";
            case "saturday": return "10";
            case "sunday": return "10";
            default: return "error;"
        }
    }else if(movieTitle === "the wizard of oz"){
        switch (dayOfTheWeek) {
            case "monday": return "10";
            case "tuesday": return "10";
            case "wednesday": return "10";
            case "thursday": return "10";
            case "friday": return "10";
            case "saturday": return "15";
            case "sunday": return "15";
            default: return "error;"
        }
    }else{
        return "error";
    }
}


console.log(moviePrice(["The Godfather", "Monday"]));