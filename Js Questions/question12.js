/*
Create a function pageNumberingWithInk2(obj1, obj2) and returns last page number that can be 
printed using the given amount of ink

functionality:  start from the currentPage and count the number of digits required to print 
                the current page number.
                If the remaining numberOfDigits is greater than or equal to the required digits to 
                print the current page number, subtract the required digits from the numberOfDigits and 
                move to the next page. Continue this process until numberOfDigits is not enough to print 
                the current page number. Finally, return the last page number that can be printed.

Ex :console.log(pageNumberingWithInk2({currentPage: 1, numberOfDigits: 5})); => 5
    console.log(pageNumberingWithInk2({currentPage: 21, numberOfDigits: 5})); => 22
    console.log(pageNumberingWithInk2({currentPage: 8, numberOfDigits: 4})); => 10
    console.log(pageNumberingWithInk2({currentPage: 7, numberOfDigits: 4})); => 9
*/
function pageNumberingWithInk2({ currentPage, numberOfDigits })
{
    let ink = numberOfDigits;
    let page = currentPage;

    while (ink >= page.toString().length)
    {
        ink -= page.toString().length;
        page++;
    }
    return page - 1;
}
console.log(pageNumberingWithInk2({ currentPage: 1, numberOfDigits: 5 }));
console.log(pageNumberingWithInk2({ currentPage: 21, numberOfDigits: 5 }));
console.log(pageNumberingWithInk2({ currentPage: 8, numberOfDigits: 4 }));
console.log(pageNumberingWithInk2({ currentPage: 7, numberOfDigits: 4 }));
console.log(pageNumberingWithInk2({ currentPage: 21, numberOfDigits: 6 }));
console.log(pageNumberingWithInk2({ currentPage: 0, numberOfDigits: 100 }));