solution("abc","a");

function solution(str, ending){
    /*if(str[str.length - 1] === ending[ending.length - 1])
        return true;
    else
        return false;*/

    return !!str.endsWith(ending);
}
