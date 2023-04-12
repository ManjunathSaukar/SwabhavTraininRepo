function checkIsAnagram(str1, str2)
{
    str1 = str1.toLowerCase();
    str2 = str2.toLowerCase();
    if (str1.length !== str2.length)
    {
        return false;
    }
    str1 = str1.split("").sort().join("");
    str2 = str2.split("").sort().join("");

    return str1 === str2;
}
function checkAnagram()
{
    const input1 = document.getElementById("input1").value;
    const input2 = document.getElementById("input2").value;
    const isAnagram = checkIsAnagram(input1, input2);
    const yesButton = document.getElementById("yes");
    const noButton = document.getElementById("no");
    if (isAnagram)
    {
        yesButton.style.backgroundColor = "green";
        noButton.style.backgroundColor = "gray";
    } else
    {
        yesButton.style.backgroundColor = "gray";
        noButton.style.backgroundColor = "red";
    }
}
