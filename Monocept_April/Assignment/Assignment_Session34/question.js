var backButton = document.querySelector("#back")
var nextButton = document.querySelector("#next")
var finishButton = document.querySelector("#finish")
var saveButton = document.querySelector("#save")
var question = document.querySelector("#question")
var result = document.querySelector('#result')


var questions = [{ id: 1, question: "What is the capital of india ?", options: ["Patna", "Delhi", "Kolkata", "Varanasi"], answer: "Delhi" },
{ id: 2, question: "Which one of the following river flows between Vindhyan and Satpura ranges ?", options: ["Narmada", "Mahanadi", "Son", "Netravati"], answer: "Narmada" },
{ id: 3, question: "The Central Rice Research Station is situated in ?", options: ["Chennai", "Cuttack", "Bangalore", "Quilon"], answer: "Cuttack" },
{ id: 4, question: "Who among the following wrote Sanskrit grammar? ", options: ["Kalidasa", "Charak", "Panini", "Aryabhatt"], answer: "Panini" },
{ id: 5, question: "Which among the following headstreams meets the Ganges in last? ", options: ["Alaknanda", "Pindar", "Mandakini", "Bhagirathi"], answer: "Bhagirathi" }
]

var userOption = []

var i = 1;
backButton.disabled = true;
finishButton.style.visibility = "hidden"
displayQuestion(i)

function next()
{
    i++
    if (i == questions.length)
    {
        nextButton.disabled = true;
        finishButton.style.visibility = 'visible';
    }
    backButton.disabled = false;
    displayQuestion(i)
    save()
}
function back()
{
    i--;
    if (i == 1)
    {
        backButton.disabled = true;
    }
    nextButton.disabled = false;
    displayQuestion(i)
    save()
}

function displayQuestion(noOfQuestion)
{
    var ques = `(${noOfQuestion}/${questions.length})&nbsp;&nbsp;&nbsp;
            ${questions[noOfQuestion - 1].question}<br><br><br>
            <input type="radio" name="userchoice" value="${questions[noOfQuestion - 1].options[0]}">${questions[noOfQuestion - 1].options[0]}
            <input type="radio" name="userchoice" name="option" value="${questions[noOfQuestion - 1].options[1]}">${questions[noOfQuestion - 1].options[1]}<br><br>
            <input type="radio" name="userchoice" name="option" value="${questions[noOfQuestion - 1].options[2]}">${questions[noOfQuestion - 1].options[2]}
            <input type="radio" name="userchoice" name="option" value="${questions[noOfQuestion - 1].options[3]}">${questions[noOfQuestion - 1].options[3]}
            `
    question.innerHTML = ques;
}

function save()
{
    saveButton.disabled = false;
    var userChoice = document.querySelectorAll('input[name="userchoice"]')
    userChoice.forEach((currentChoice) =>
    {
        if (currentChoice.checked)
        {
            userOption.push(currentChoice.value);
            saveButton.disabled = true;
            console.log(currentChoice.checked)
            console.log(currentChoice.value)
        }
    })
    console.log(userOption)
}

function finish()
{
    question.remove();
    backButton.remove();
    nextButton.remove();
    finishButton.remove();
    saveButton.remove();

    var correct = 0;
    var wrong = 0;
    var notattempted = 0;

    for (var j = 0; j < questions.length; j++)
    {
        if (questions[j].answer == userOption[j])
        {
            correct++;
        }
        else if (userOption[i] == "Not Attempted")
        {
            notattempted++;
        }
        else
        {
            wrong++;
        }
    }
    results = `<h4>Total Correct Question is : ${correct}<br>Total Wrong Question is : ${wrong}<br>Total Not Attempted Question is : ${notattempted}</h4><br><hr>`
    for (var j = 0; j < questions.length; j++)
    {
        results += `<p>(${questions[j].id})&nbsp;${questions[j].question}</p>
                    <p>Correct Anser is : ${questions[j].answer}</p>
                    <p>Your Answer is : ${userOption[j]}</p><br>`;
    }
    result.innerHTML = results;
}