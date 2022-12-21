function getMiddle(s)
{
    console.log(s.length);
    if(s.length % 2 === 0) {
        return console.log(`${s[(s.length/2)-1]}${s[(s.length/2)]}`);
    } else {
        return console.log(`${s[s.length/2-0.5]}`);
    }
}
getMiddle("abcdefgh");