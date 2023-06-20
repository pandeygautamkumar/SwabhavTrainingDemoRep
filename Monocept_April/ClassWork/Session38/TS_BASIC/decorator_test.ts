
function NeedToRefector(description?: string) {
    return function (clsConstructor: Function) {
        console.log(description)
        console.log(clsConstructor)
    }
}

@NeedToRefector("urgent")   //Meta Data tag,wrapper ,additional behaviour
class Foo {

}
@NeedToRefector()
class Baz {

}
@NeedToRefector("not urgent")
class Bar {

}