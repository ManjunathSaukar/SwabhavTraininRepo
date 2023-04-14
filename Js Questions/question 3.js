// complete the function alphabetShift(str) and returns each alphabet shifted to 1 position to next
// alphabet ex: alphabetShift("crazy") => "dsbaz"

function alphabetShift(str)
{
    let result = '';
    for (let i = 0; i < str.length; i++)
    {
        let str2 = str.charCodeAt(i);
        if (str2 >= 97 && str2 < 122)
        {
            str2++;
        } else if (str2 == 122)
        {
            str2 = 97;
        }
        result += String.fromCharCode(str2);
    }
    return result;
}
console.log(alphabetShift("crazy"));
console.log(alphabetShift("manjunath"));
