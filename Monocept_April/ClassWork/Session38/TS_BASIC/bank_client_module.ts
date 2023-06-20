import Bank, { Account, Customer, sayHellow } from './bank_module'

let b = new Bank()
console.log(b)

let c = new Customer("Vikrant")
console.log(c)

let acc = new Account(5000)
console.log(acc)

console.log(sayHellow("Vikrant"))
