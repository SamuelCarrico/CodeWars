/*Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.
Examples

"the-stealth-warrior" gets converted to "theStealthWarrior"
"The_Stealth_Warrior" gets converted to "TheStealthWarrior"
*/


function toCamelCase(str) {
    let c = str.split('');
    const regEx = /[A-Z]/;
    for (let i = 0; i < c.length; i++) {
            if (i === 0 && c[i] === regEx) {
                c[i] = c[i].toUpperCase();
            } else if (c[i] === '-' || c[i] === '_') {
                c[i] = '';
                c[i + 1] = c[i + 1].toUpperCase();
            }
        }
    let s = c.join('');
    console.log(s);
    }

toCamelCase('koukou_c_nous');