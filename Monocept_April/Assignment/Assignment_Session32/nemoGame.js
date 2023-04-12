var okBtn = document.querySelector("#okBtn")
var box = document.querySelector("#allBox")
var rule = document.querySelector("#rule")
var randomNumber;

okBtn.addEventListener("click", function ()
{
    rule.remove();
    box.style.visibility = "visible";
    displayBox(50)
    findRandomNumber(50)
});

function displayBox(noOfBox)
{
    var allBox = "";
    for (var i = 1; i <= noOfBox; i++)
    {
        allBox += `<input type="button" onclick="boxDetail(${i})" id="box${i}" style="width: 60px;height: 40px;background: #d1cccf;margin: 10px;">`;
    }
    box.innerHTML = allBox;
}
function findRandomNumber(noOfBox)
{
    randomNumber = Math.floor(Math.random() * (noOfBox - 1 + 1) + 1);
    //console.log(randomNumber)
}
var noOfMove = 0;
function boxDetail(count)
{
    noOfMove += 1;
    var box = document.querySelector("#box" + count);
    //console.log(box)
    if (count < randomNumber)
    {
        box.style.background = "green"
        setTimeout(function ()
        {
            box.style.background = "#d1cccf"
        }, 4000);
    }
    else if (count == randomNumber)
    {
        box.style.backgroundImage = "url('nemo.jpg')";
        box.style.backgroundSize = "cover";
        var result = document.querySelector("#displayResult");
        result.innerHTML = `You Win in Total ${noOfMove} Moves.`
    }
    else
    {
        box.style.background = "Red"
        setTimeout(function ()
        {
            box.style.background = "#d1cccf"
        }, 4000);
    }
}