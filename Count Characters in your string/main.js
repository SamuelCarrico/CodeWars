/*Count characters in your string - https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/javascript
*
* The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
*
* What if the string is empty? Then the result should be empty object literal, {}.
*/

function count (string) {

    let letters = [];
    let arrayNbs = [];
    let compteur = 1;
    let j = 0;
    let c = [...string];


    for(let i = 0; i < c.length; i++) {
        if(c.length === 0) {
            return "";
        }
        if(c[i] !== c[i+1]) {
            letters[i] = c[i];
            arrayNbs[j] = compteur;
            compteur = 1;
            if(compteur === 1) {
                j++;
            }
        } else {
            letters.splice(i,1);
            compteur++;
        }
    }

    let emptied = letters.filter(value => value.length > 0);

    for(let i = 0; i < emptied.length; i++) {
        console.log(`${emptied[i]} : ${arrayNbs[i]}`);
    }
}

count('aabbb');