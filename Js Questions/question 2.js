//1. Create an Add function that takes any number of integers and returns the sum of those elements
// use rest parameter (this is just like params in C#)
// example : Add(10,20,30,40) => 150
//2. Create a function findLargestString(string array) that returns an array of largest strings
// example : FindLargestString(["abcd","ab","abc"]) => ["abcd"]

function Add(...nums)
{
    var sum = 0;
    for (const num of nums)
    {
        sum += num;
    }
    return sum;
}
console.log(Add(10, 20, 30, 40, 50));
console.log(Add(10));
console.log(Add(10, 20, 30));

function findLargestString(arr)
{
    let maxLength = 0;
    let longestStrings = [];

    for (var i = 0; i < arr.length; i++)
    {
        if (arr[i].length > maxLength)
        {
            maxLength = arr[i].length;
            longestStrings = [arr[i]]
        }
        else if (arr[i].length === maxLength)
        {
            longestStrings.push(arr[i]);
        }
    }
    return longestStrings;
}
console.log(findLargestString(["abcd","abc","ab","a"]));
console.log(findLargestString(["def","abc","ab","a"]));