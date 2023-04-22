/*
Create a function areSimilar([int], [int]) returns a boolean based on the similarites of the arrays
The arrays are similar if :
1. Two arrays are similar if they can be obtained from each other by swapping at 
most two elements in one of the arrays.
2. If the two arrays are already identical, they are considered similar.

ex:
console.log(areSimilar([1,2], [2,1])); => true
console.log(areSimilar([1,2,3,4], [2,1,3,4])); => true
console.log(areSimilar([1,2,3,4], [3,4,2,1])); => false
console.log(areSimilar([1,2,3,4], [2,1,4,3])); => false
console.log(areSimilar([1,2,3,4], [4,2,3,1])); => true

*/
function areSimilar(arr1, arr2)
{
    if (arr1.length !== arr2.length)
    {
        return false;
    }

    let diffCount = 0;
    let diffIndices = [];

    for (let i = 0; i < arr1.length; i++)
    {
        if (arr1[i] !== arr2[i])
        {
            diffCount++;
            diffIndices.push(i);
        }
        if (diffCount > 2)
        {
            return false;
        }
    }
    if (diffCount === 0)
    {
        return true;
    } else if (diffCount === 2)
    {
        return arr1[diffIndices[0]] === arr2[diffIndices[1]] && arr1[diffIndices[1]] === arr2[diffIndices[0]];
    } else
    {
        return false;
    }
}
console.log(areSimilar([1, 2], [2, 1]));
console.log(areSimilar([1, 2, 3, 4], [2, 1, 3, 4]));
console.log(areSimilar([1, 2, 3, 4], [3, 4, 2, 1]));
console.log(areSimilar([1, 2, 3, 4], [2, 1, 4, 3]));
console.log(areSimilar([1, 2, 3, 4], [4, 2, 3, 1]));

function areSimilar1(arr1, arr2)
{
    if (arr1.length !== arr2.length)
        return false;

    let diffCount = 0;

    for (let i = 0; i < arr1.length; i++)
    {
        if (arr1[i] !== arr2[i])
            diffCount++
        if (diffCount > 2)
            return false
    }
    return true
}


console.log(areSimilar1([1, 2], [2, 1]));
console.log(areSimilar1([1, 2, 3, 4], [2, 1, 3, 4]));
console.log(areSimilar1([1, 2, 3, 4], [3, 4, 2, 1]));
console.log(areSimilar1([1, 2, 3, 4], [2, 1, 4, 3]));
console.log(areSimilar1([1, 2, 3, 4], [4, 2, 3, 1]));