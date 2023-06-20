export default class Bank {
    constructor(public name = "Icici", public location = "Mumbai") {
        sayHello(name)
    }
}
export class Customer {
    constructor(public name = "Ashish") {

    }
}
export class Account {
    constructor(public balance = 500) {

    }
}
function sayHello(name: string) {
    console.log("Hello Say : ", name);
}