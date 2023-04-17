// create a function alphabeticSubSequence(str) returns boolean. returns true if all the alphabets 
// in the string are in squence and returns false if they are not and also returns false if 
// the alphabets are repeated even if they are in sequence. 
// Ex : console.log(alphabetSubSequence("effg")); => false
//      console.log(alphabetSubSequence("ace")); => true 
//      console.log(alphabetSubSequence("xab")); => false

function alphabetSubSequence(str){
    for(let i =0;i<str.length-1;i++){
        if(str.charCodeAt(i)>=str.charCodeAt(i+1)){
            return false;
        }
    }
    const set = new Set(str);
    return set.size === str.length;
}

console.log(alphabetSubSequence("effg"));
console.log(alphabetSubSequence("ace"));
console.log(alphabetSubSequence("xab"));
console.log(alphabetSubSequence("ade"));