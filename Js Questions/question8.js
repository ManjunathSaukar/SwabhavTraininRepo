/*
create a function arrayConversion([int]) returns [int]
the functionlaity of the program is it should add the adjacent elements for odd iterations
and for even iterations it should multiply the elements and return a should multiply the elements

ex : console.log(arrayConversion([1,2,3,4,5,6,7,8])); =>[186]
    [3,7,11,15] => [21,165] => [186]

    [3,7,11,15] => [10,26] => [36]
*/
function arrayConversion(arr){
    let isOdd = true;

    while(arr.length>1){
        let temp =[];

        for(let i=0;i<arr.length;i+=2){
            if(isOdd)
                temp.push(arr[i]+arr[i+1]);
            else
                temp.push(arr[i]*arr[i+1]);
        }
        console.log(temp);
        arr = temp;
        isOdd=!isOdd;
    }
    return arr;
}
console.log(arrayConversion([1,2,3,4,5,6,7,8]));
console.log(arrayConversion([1,2,3,4,5,6]));


