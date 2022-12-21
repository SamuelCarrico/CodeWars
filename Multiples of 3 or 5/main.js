/* Multiples of 3 or 5 - https://www.codewars.com/kata/514b92a657cdc65150000006/train/javascript

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).


Note: If the number is a multiple of both 3 and 5, only count it once.
 */

function solution(number){
    let array = [];

    if(number < 0) {
        return 0;
    }


    for(let i = 0; i < number; i++) {
        let diff = number - i - 1 ;
        let modulo3 = diff % 3;
        let modulo5 = diff % 5;

        if(modulo3 === 0)  {
            array[i] = diff;
        }
        if (modulo5 === 0) {
            array[i] = diff;
        }
    }
    const arrayFilterednReduced = array.filter(value => value > 0).reduce((acc, cValue) => (acc + cValue),0 );
    return console.log(arrayFilterednReduced);
}

solution(10);