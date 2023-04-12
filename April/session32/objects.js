var names = []
console.log(names)
names.push("Manjunath")
names.push("Abhi")
names.push("Anirudh")
console.log(names)
names.unshift("Monocept")
console.log(names)

names.forEach((n) => console.log(n.toUpperCase()))

var names_with_a = names.filter((name) => name.includes("a"))
console.log(names_with_a)

var strNos = ["10", "20", "30", "40", "50"]
strNos.map(no => console.log(parseInt(no) + parseInt(no)))

var sum = strNos.map(no => { return parseInt(no) })
    .reduce((a, b) => a + b)
console.log(sum)

var users = [{ id: 101, name: "Manjunath", salary: 1000 },
{ id: 102, name: "Abhi", salary: 2000 },
{ id: 103, name: "Anirudh", salary: 2000 }]
users.forEach((u) => console.log(u.id, u.name, u.salary))

var totalSalary = 0;
for (var i = 0; i < users.length; i++)
{
    totalSalary += users[i].salary;
}
console.log(totalSalary)

var totalSalary = users.reduce((sum, user) => sum + user.salary, 0);
console.log("Total Salary:", totalSalary);