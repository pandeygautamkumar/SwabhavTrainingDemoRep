import { Component } from "@angular/core"
import { ICustomer } from "./customer/ICustomer"

@Component({
    selector: '.pro-welcome',
    templateUrl: 'welcome.component.html'
})

export class WelcomeComponent {
    message: string
    customers: ICustomer[] = new Array<ICustomer>()
    currentRatingValue: string = ""
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
    ratingClickHandler(dataFromChild: string) {
        console.log("Inside Rating Click Handler of Parent.")
        console.log(dataFromChild.toUpperCase())
        this.currentRatingValue = dataFromChild;
    }
}