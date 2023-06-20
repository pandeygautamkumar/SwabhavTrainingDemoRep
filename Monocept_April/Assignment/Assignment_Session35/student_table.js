var studentDetail = []
if (localStorage.getItem('students'))
{
    studentDetail = JSON.parse(localStorage.getItem('students'));
}
displayRecord()

function addStudentData()
{
    readStudentData();
    displayRecord()
    console.log(studentDetail)
    reset()
}

function readStudentData()
{
    var studentData = {}
    studentData["Name"] = document.querySelector("#name").value;
    studentData["Gender"] = document.querySelector('input[name="gender"]:checked').value;
    studentData["Branch"] = document.querySelector("#branch").value;
    var cgpa = document.querySelector("#cgpa").value;
    if (cgpa < 0 || cgpa > 10)
    {
        alert('CGPA must be between 1 to 10.0')
    }
    else
    {
        studentData["CGPA"] = cgpa;
    }
    studentDetail.push(studentData)
    localStorage.setItem('students', JSON.stringify(studentDetail));
}


function displayRecord()
{
    var table = `<table border='1'><tr>
                <th>Name</th>
                <th>Gender</th> 
                <th>Branch</th>
                <th>CGPA</th>
                <th></th>
                </tr>`
    for (var i = 0; i < studentDetail.length; i++)
    {
        table +=
            `<tr>
                    <td>${studentDetail[i].Name}</td>
                    <td>${studentDetail[i].Gender}</td>
                    <td>${studentDetail[i].Branch}</td>
                    <td>${studentDetail[i].CGPA}</td>
                    <td><button onclick='onDelete(${i})'>Delete</button></td>
                    </tr>`
    }
    table += `</table>`
    document.querySelector('#display').innerHTML = table;
}


function onDelete(row)
{
    studentDetail.splice(row, 1);
    localStorage.setItem('students', JSON.stringify(studentDetail));
    displayRecord();
}

function reset()
{
    document.querySelector("#name").value = "";
    document.querySelector('input[name="gender"]:checked').checked = false;
    document.querySelector("#branch").value = "";
    document.querySelector("#cgpa").value = "";
}