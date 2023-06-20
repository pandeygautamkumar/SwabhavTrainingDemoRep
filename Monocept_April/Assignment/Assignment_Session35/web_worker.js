var i = 0;

function timedCount()
{
    i = i + 1;
    postMessage(i);
    setTimeout(function ()
    {
        timedCount()
    }, 500);
}

timedCount();