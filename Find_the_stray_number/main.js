const array = [1, 2, 1];
const array2 = [17, 17, 17, 3, 17, 17, 17];
const array3 = [17, 17, 17, 3, 17, 17, 17, 17];
const array4 = [2,2,1];


function stray(numbers) {
    for (let i = 0; i < numbers.length; i++) {
        if (i === 0 && numbers.length % 3 === 0) {
            if (numbers[i] !== numbers[i + 1] && numbers[i] === numbers [i+2]) {
                return numbers[i+1];
            } else if (numbers[i] !== numbers[i + 1]) {
                return numbers[i];
            }
        } else if (i === (numbers.length - 2)) {
            if (numbers[i] !== numbers[i + 1]) {
                return numbers[i + 1];
            }
        } else if (numbers[i] !== numbers[i + 1]) {
            return numbers[i + 1];
        }
    }
}

stray(array4);