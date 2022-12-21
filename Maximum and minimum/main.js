/* Maximum and minimum - https://www.codewars.com/kata/59c0cd4f46038781010000ac/train/javascript
Write two functions max and min which returns the maximum and minimum value of the argument passed into them respectively.
Example

    max(1,2,3,4) //returns 4
    max(1,2,3,['4']) //returns 4; note it returned 4 not '4'
    max(1,2,[3,4]) //returns 4
    max(1,2,[3,[4]]) //returns 4
    max(1,2,[3,['4r']]) //returns NaN
    max([[],[-4]]) // returns -4
    max() or max([]) //returns 0

And so goes for min
Further Instructions

    functions will take any number of arguments
    Arrays of numbers can be to any depth
   ! You can't use Math.max, Math.min, and require !
    If one of the arguments can not be evaluated to a number, return NaN
*/

function max(numbers) {
    const c = numbers.toString().split('');
    let maxV = c[0];

    for (let i = 0; i < c.length; i++) {
        if (Number.isNaN((c[i]))) {
            return NaN;
        }
        for (let j = i + 1; j < c.length - 1; j++) {
            if (c[j] > c[i]) {
                i = j;
                maxV = c[i];
            }
        }
    }
    return console.log(maxV);
}

function min(numbers) {

    const c = numbers.toString().split('');
    let minV = c[0];

    for (let i = 0; i < c.length; i++) {
        if (Number.isNaN((c[i]))) {
            return NaN;
        }
        for (let j = i + 1; j < c.length - 1; j++) {
            if (c[j] < c[i]) {
                i = j;
                minV = c[i];
            }
        }
    }
    return console.log(minV);
}

max(125943);
min(5550688);