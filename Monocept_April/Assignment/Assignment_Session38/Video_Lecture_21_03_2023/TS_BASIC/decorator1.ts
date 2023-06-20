function NeedToRefectorLater(detail: string) {
    return function (classConstructorfn: Function) {
        console.log(detail.toUpperCase())
        console.log(classConstructorfn.name)
        console.log(classConstructorfn)
    }
}

@NeedToRefectorLater("Very Urgent")
class Foo {
    constructor(public description = "Foo") {

    }
}

@NeedToRefectorLater("Urgent")
class Bar {
    constructor(public description = "Bar") {

    }
}