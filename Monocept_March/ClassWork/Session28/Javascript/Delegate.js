var fptr=function f1(){
    console.log("Inside f1");
}

var f1ptr=fptr;

fptr();

fptr=function f2(){
    console.log("Inside f2");
}

fptr();

function doSomething(callback_ptr){
    console.log("doing Something");
    console.log("Completing Work.");
    callback_ptr();
}
doSomething(function(){
    console.log("Inside Anonymous function.");
});

setTimeout(function(){
    console.log("inside anonymous function 2 after 3");
},3000);
