/*create a function alternating_sum(int array) returns int array here this function will return 
an array of all the sum of even indices and odd indices
ex : console.log(alternating_sum([50,60,60,45,70]) => [180,105]
    console.log(alternating_sum([50,60,60]) => [110,60]
    console.log(alternating_sum([50,60]) => [50,60]*/

function alternating_sum(arr)
{
    let evenSum = 0;
    let oddSum = 0;

    if (arr.length == 1)
    {
        return arr;
    }

    for (let i = 0; i < arr.length; i++)
    {

        if (i % 2 === 0)
        {
            evenSum += arr[i];
        }
        else
        {
            oddSum += arr[i];
        }
    }
    return [evenSum, oddSum];
}
console.log(alternating_sum([50, 60, 60, 45, 70]));
console.log(alternating_sum([50, 60, 60]));
console.log(alternating_sum([50, 60]));
console.log(alternating_sum([50]));