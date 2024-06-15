const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function isEven(number) {
    if (number % 2 === 0) {
        return 2;  // Number is even
    } else {
        return 1;  // Number is odd
    }
}

rl.question("Enter a number: ", function(input) {
    const number = parseInt(input, 10);
    console.log(isEven(number));
    rl.close();
});
