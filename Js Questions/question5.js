/* 1. create a function max_adjacentTwoElementsProduct([int array]) and returns the maximum product of two 
adjacent elements 
ex : console.log(max_adjacentTwoElementsProduct([3,6,2,5,7,3]) => 35
   : console.log(max_adjacentTwoElementsProduct([3,6,-2,-5,7,3]) =>  21

2. create a function max_adjacentThreeElementsProduct([int array]) and returns the maximum product of three 
adjacent elements
ex : console.log(max_adjacentThreeElementsProduct([3,6,2,5,7,3]) => 105
   : console.log(max_adjacentThreeElementsProduct([3,6,-2,-5,7,3]) =>  70
*/

function max_adjacentTwoElementsProduct(arr)
{
    let maxProduct = -Infinity;
    for (let i = 0; i < arr.length - 1; i++)
    {
        const product = arr[i] * arr[i + 1];
        if (product > maxProduct)
        {
            maxProduct = product;
        }
    }
    return maxProduct;
}
console.log(max_adjacentTwoElementsProduct([3,6,2,5,7,3]));
console.log(max_adjacentTwoElementsProduct([3,6,-2,-5,7,3]));

function max_adjacentThreeElementsProduct(arr)
{
    let maxProduct = -Infinity;
    for (let i = 0; i < arr.length - 2; i++)
    {
        const product = arr[i] * arr[i + 1]*arr[i+2];
        if (product > maxProduct)
        {
            maxProduct = product;
        }
    }
    return maxProduct;
}
console.log(max_adjacentThreeElementsProduct([3,6,2,5,7,3]));
console.log(max_adjacentThreeElementsProduct([3,6,-2,-5,7,3]));