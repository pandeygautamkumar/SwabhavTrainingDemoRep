function checkIsAnagram(string1, string2)
{
    if (string1.length != string2.length) return false;

    var NO_OF_CHARACTER = 256;
    var freq = new Array(NO_OF_CHARACTER);
    for (var i = 0; i < NO_OF_CHARACTER; i++)
    {
        freq[i] = 0;
    }
    for (var i = 0; i < string1.length; i++)
    {
        freq[string1[i].charCodeAt(0)]++;
        freq[string2[i].charCodeAt(0)]--;
    }
    for (var i = 0; i < NO_OF_CHARACTER; i++)
    {
        console.log(freq[i]);
        if (freq[i] != 0)
        {
            return false;
        }
    }
    return true;
}

console.log(checkIsAnagram("HEART", "EARTH"));
console.log(checkIsAnagram("heart", "earth"));