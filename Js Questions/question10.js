/*
create a function checkParity(str) returns string
functionality : the function will check the given string and returns odd or even or not a digit

ex: console.log(checkParity("5")); => odd
    console.log(checkParity("8")); => even
    console.log(checkParity("q")); => not a digit
*/

function checkParity(str)
{
    const ascii = str.charCodeAt(0);

    if (ascii >= 48 && ascii <= 57)
    {
        return (ascii % 2 === 0) ? "even" : "odd";
    } else
    {
        return "not a digit";
    }
}
console.log(checkParity("5"));
console.log(checkParity("8"));
console.log(checkParity("a"));