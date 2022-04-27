// Strings operations
var language = "javascript";

// Print length of variable
console.log(`Lenght of language variable => ${language.length}`);

// Slicing the string and printing the result
var slicedString = language.slice(start=0, end=4);
console.log(`Original: ${language} => Sliced: ${slicedString}`);

// Concatenanting strings
var slicedString2 = language.slice(start=4)
var reformedString = slicedString.concat(slicedString2)
console.log(`${slicedString} concatenated with ${slicedString2} => ${reformedString}`)


// Numbers operations
var num1, num2, num3;
function sumListOfNumbers(a, b, c)
{
    if (!isNaN(num1) && !isNaN(num2) && !isNaN(num3))
    {
        return a + b + c
    }
    return null
}

num1 = "x"
num2 = 45
num3= -5

var result = sumListOfNumbers(num1, num2, num3)
console.log(`Sum of ${num1} + ${num2} + ${num3} => ${result}`)

// Bool operations

// function that uses parseInt of arguments and returns false for Nan / true otherwise
function inputIsNumber(number)
{
    var isNumber;
    var numToInt = parseInt(number)
    
    if (isNaN(numToInt))
    {
        isNumber = false
        numToInt = null;
    }
    else
    {
        isNumber = true
    }

    // return both bool and int as values in object
    return {"valid": isNumber, "number": numToInt}
}


// Get console input
input = prompt()
// check if input is number or not using the function above
var result = inputIsNumber(input)
// Print the results
console.log(`Input "${input}" is a number: ${result.valid}. The number is ${result.number}.`)

// == vs ===

// == operator converts the operants to the same type and then makes the comparison
console.log(10 == 10) // returns true
console.log("10" == 10) // returns true after conversion
console.log(4 == 10) // return false
console.log("4" == 10) // returns false after conversion

// === operator compares without any type conversion
// and returns true only if both the values and the types are identical
console.log(10 === 10) // returns true
console.log("10" === 10) // return false because one type is different