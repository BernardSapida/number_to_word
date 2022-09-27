const numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
const tens = ["twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
// const wordNumbers3 = ["hundred", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion"];

function convertToWord(number) {
    if(number < 20) return numbers[number];

    let digit = number%10;
    if(number < 100) return tens[Math.floor(number/10)-2] + (digit ? " " + numbers[digit] : "");
    if(number < 1000) return numbers[Math.floor(number/100)] + " hundred " + (number % 100 == 0 ? "" : convertToWord(number % 100));
    return convertToWord(Math.floor(number/1000)) + " thousand " + (number % 1000 != 0 ? " " + convertToWord(number % 1000) : "");
}

console.log(convertToWord(22));