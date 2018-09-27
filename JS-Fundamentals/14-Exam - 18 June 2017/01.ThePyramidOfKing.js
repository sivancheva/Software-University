function thePyramidOfKing(size, height) {

    let stones = 0;
    let marble = 0;
    let lapisLazuli = 0;
    let gold = 0;
    let pyramidHeight = 0;
    let isBuilt = false;

    while (size >= 0) {

        pyramidHeight++;

        if (size === 1 || size === 2) {
            gold = (size *size* height);
            isBuilt = true;
            break;
        }

        stones +=(Math.pow((size-2), 2)*height);

        if (pyramidHeight % 5 === 0) {
            lapisLazuli += (4*size - 4)*height;
        }else{
            marble += (4*height*(size-1));
        }

        size -= 2;
        if (isBuilt) {
            break;
        }

    }

    console.log(`Stone required: ${Math.ceil(stones)}`);
    console.log(`Marble required: ${Math.ceil(marble)}`);
    console.log(`Lapis Lazuli required: ${Math.ceil(lapisLazuli)}`);
    console.log(`Gold required: ${Math.ceil(gold)}`);
    console.log(`Final pyramid height: ${Math.floor(pyramidHeight*height)}`);
}

thePyramidOfKing(12, 1);


