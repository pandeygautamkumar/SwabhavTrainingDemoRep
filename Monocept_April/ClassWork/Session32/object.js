var names = []
console.log(names)

names.push("Ekta")
names.push("Vikrant")
names.push("Anikant")
console.log(names)

names.unshift("Monocept")
console.log(names)

for (var i = 0; i < names.length; i++)  // Explicity Looping
{
    console.log(names[i])
}

names.forEach(printDetails);    // Implicitally Called

function printDetails(name)      
{
    console.log(name)
}


names.forEach((e) => console.group(e))      // through lambda method

var names_with_a = names.filter((name) => name.includes("a"));

console.log(names_with_a)

var strNos = ["10", "20", "30", "40"]

strNos.map((no) => console.log(no * no))
strNos.map((no) => console.log(no + no))

strNos.map((no) => console.log(parseInt(no) + parseInt(no)))



var sum = strNos.map((no) => { return parseInt(no) })
    .reduce((a, b) => a + b)

console.log(sum)



var users = [{ id: 101, name: "Anekant", salary: 1000 }, { id: 102, name: "Vikrant", salary: 2000 }]
users.forEach((u) => console.log(u.id, u.name, u.salary))

var sumOfSalary = users.map((user) => { return user.salary })
    .reduce((a, b) => a + b)

console.log("Total Slary : " + sumOfSalary)

// By using functional Programming

sumOfSalary = 0;
for (var i = 0; i < users.length; i++)
{
    sumOfSalary += users[i].salary;
}
console.log(sumOfSalary)