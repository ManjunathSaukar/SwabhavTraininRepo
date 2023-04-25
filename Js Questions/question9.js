/*
create a function getCellColor(str) and returns string

functionality : refer a chess board, in that for X axis there are alphabets from A to H
and for Y axis there are numbers from 1 to 8
and whenever thefunction is called it should return a string saying whether the given cell(box of square)
is is Dark Square or Light Square

ex: console.log(getCellColor('A1')); => Dark Square
    console.log(getCellColor('a1')); => Dark Square
    console.log(getCellColor('b1')); => Light Square
    console.log(getCellColor('B1')); => Light Square
*/

function getCellColor(cell)
{
    const x = cell[0].toLowerCase().charCodeAt(0) - 97;
    const y = parseInt(cell[1], 10) - 1;
    const isDark = (x + y) % 2 === 0;
    return isDark ? "Dark Square" : "Light Square";
}
console.log(getCellColor('A1'));
console.log(getCellColor('a1'));
console.log(getCellColor('B1'));
console.log(getCellColor('b1'));
console.log(getCellColor('A2'));
console.log(getCellColor('D5'));