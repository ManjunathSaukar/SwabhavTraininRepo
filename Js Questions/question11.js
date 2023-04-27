/*
create 2 functions checkPalindrome(str) and isCaseInsensitivePalindrome(str) which retruns boolean

functionality : checkPalindrome(str) returns true if the string is palindrome else false,
                isCaseInsensitivePalindrome(str) returns true if the string is palindrome and case 
                insensitive

ex :console.log(isCaseInsensitivePalindrome("abac")); => false
    console.log(checkPalindrome("abac")); => false
    console.log(isCaseInsensitivePalindrome("madaM")); => true
    console.log(checkPalindrome("madaM")); => false
*/

function checkPalindrome(str)
{
    const reversedStr = str.split('').reverse().join('');
    return str === reversedStr;
}

function isCaseInsensitivePalindrome(str)
{
    const lowerCaseStr = str.toLowerCase();
    return checkPalindrome(lowerCaseStr);
}

console.log(isCaseInsensitivePalindrome("abac"));
console.log(checkPalindrome("abac"));
console.log(isCaseInsensitivePalindrome("madaM"));
console.log(checkPalindrome("madaM")); 