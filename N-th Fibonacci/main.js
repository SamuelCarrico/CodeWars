/* N-th Fibonacci - https://www.codewars.com/kata/522551eee9abb932420004a0/train/javascript
* I love Fibonacci numbers in general, but I must admit I love some more than others.

I would like for you to write me a function that when given a number (n) returns the n-th number in the Fibonacci Sequence.

For example:

   nthFibo(4) == 2

Because 2 is the 4th number in the Fibonacci Sequence.

For reference, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.

* */

function nthFibo(n) {
    let array = [];
    for(let i = 2; i < n; i++) {
        array[0] = 0;
        array[1] = 1;
        array[i] = array[i-1] + array[i-2];
    }
    if(n === 0 || n === 1) {
        return console.log(0);
    } else if (n === 2) {
        return console.log(1);
    } else {
        return console.log(array[n-1]);
    }
}

nthFibo(1);