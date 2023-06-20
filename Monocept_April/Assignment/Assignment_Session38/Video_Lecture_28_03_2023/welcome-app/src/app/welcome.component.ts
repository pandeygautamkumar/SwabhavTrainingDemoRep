import { Component } from "@angular/core"
import { ICustomer } from "./customer/ICustomer"

@Component({
    selector: '.pro-welcome',
    templateUrl: 'welcome.component.html'
})

export class WelcomeComponent {
    message: string
    customers: ICustomer[] = new Array<ICustomer>()
    constructor() {
        this.message = "Welcome to first component"

        this.customers.push({ firstName: "Gautam", lastName: "Pandey" })
        this.customers.push({ firstName: "Ravi", lastName: "Kumar" })
        this.customers.push({ firstName: "Anikant", lastName: "Kumar" })
        this.customers.push({ firstName: "Rahul", lastName: "Kumar" })
    }
    getColor(index: number) {
        if (index % 2 == 0) return "red"
        else return "blue"
    }
}