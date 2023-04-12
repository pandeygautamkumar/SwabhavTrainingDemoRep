function checkIsAnagram()
{
    var string1 = document.querySelector(".first").value;
    var string2 = document.querySelector(".second").value;
    var result;
    if (string1.length != string2.length)
    {
        result = "No"
    }
    else
    {
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
            if (freq[i] != 0)
            {
                result = "No";
            }
        }
        result = "Yes";
    }
    var Result = document.getElementById("result");
    Result.innerHTML = result;
    Result.style.margin = "0 120px";
    if (result == "No")
    {
        Result.style.background = "Red";
    } else
    {
        Result.style.background = "MediumSeaGreen";
    }
}

