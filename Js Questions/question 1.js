// create a function addBorder(string arr) that returns an array, so that the output has * attached at front 
//  and back ex: ip : [abcde, def] / op : [*abcde*, *def*]

// function addBorder(arr){
//     var newArr =[]
//     while(arr.length>0){
//         var str = arr.shift();
//         var newStr = "*" + str + "*";
//         newArr.push(newStr)
//     }
//     return newArr;
// }

// function addBorder(arr){
//     return arr.map(function(str){
//         return "*" + str + "*";
//     });
// }

//Ravi's idea
function addBorder(arr)
{
    for (var i = 0; i < arr.length; i++)
    {
        arr[i] = "*" + arr[i] + "*";
    }
    return arr
}
console.log(addBorder(["abcde", "def", "ravi"]));