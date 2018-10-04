function restHouse(rooms, guests) {


    let result = new Map();

    for (let room of rooms) {
        let roomNumber = room.number;
        let bedCount = room.type === "double-bedded" ? 2 : 3;

        if (!result.has(roomNumber)) {
            result.set(roomNumber, {});
            result.get(roomNumber).type = room.type;
            result.get(roomNumber).beds = bedCount;
            result.get(roomNumber).guests = [];
        }
    }

    console.log(result);
    for (let pairGuests of guests) {

        let firstGuest = pairGuests["first"];
        let secondGuest = pairGuests["second"];

        if (firstGuest.gender !== secondGuest.gender) {

            let roomNumbers = result.keys();
            roomNumbers = [...roomNumbers];

            for (let room of roomNumbers) {
                if (result.get(room).type === "double-bedded" && result.get(room).beds === 2) {
                    result.get(room).guests.push(firstGuest);
                    result.get(room).guests.push(secondGuest);
                    result.get(room).beds -= 2;
                }
            }
        }
    }

}

// function deleteGuest(guests, guestNameToDelete) {
//
//     let guestNumber = guests.keys();
//     guestNumber = [...guestNumber];
//
//     for (let room of guestNumber) {
//         if (room.name === guestNameToDelete) {
//             delete guests
//         }
//     }
// }


restHouse([{number: '206', type: 'double-bedded'},
        {number: '311', type: 'triple'}],
    [{
        first: {name: 'Tanya Popova', gender: 'female', age: 24},
        second: {name: 'Miglena Yovcheva', gender: 'female', age: 23}
    },
        {
            first: {name: 'Katerina Stefanova', gender: 'female', age: 23},
            second: {name: 'Angel Nachev', gender: 'male', age: 22}
        },
        {
            first: {name: 'Tatyana Germanova', gender: 'female', age: 23},
            second: {name: 'Boryana Baeva', gender: 'female', age: 22}
        }]);