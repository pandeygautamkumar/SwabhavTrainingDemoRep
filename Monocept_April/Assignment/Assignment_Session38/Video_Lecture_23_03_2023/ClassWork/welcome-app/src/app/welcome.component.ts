import { Component } from "@angular/core"
@Component({
    selector: '.pro-welcome',
    templateUrl: 'welcome.component.html'
})

export class WelcomeComponent {
    message: string
    constructor() {
        this.message = "Welcome to first component"
    }
}