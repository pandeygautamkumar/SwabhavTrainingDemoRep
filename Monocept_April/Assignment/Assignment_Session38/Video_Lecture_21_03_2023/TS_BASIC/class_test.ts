class studentV1 {
    name: string
    cgpa: number
    constructor(pname = "", pcgpa = 0) {
        this.name = pname
        this.cgpa = pcgpa
    }
}
let s1 = new studentV1("Raj", 8.9)
s1.name = "Sachin"
//s1.cgpa = 7.5
console.log(s1)


class StudentV2 {
    constructor(public name = "", public cgpa = 0) {

    }
}
let s2 = new StudentV2("Ashish", 8)
s2.name = "Santanu"
console.log(s2)

class StudentV3 {
    constructor(private name = "", private cgpa = 0) {

    }
    getName() {
        return this.name;
    }
    getCgpa() {
        return this.cgpa;
    }
    setName(pname: string) {
        this.name = pname;
    }
    setCgpa(pcgpa: number) {
        this.cgpa = pcgpa;
    }
}
let s3 = new StudentV3("Aditi", 7.5)
console.log(s3)
//s3.name="Aditi";
s3.setName("Raj")
console.log(s3.getName())
console.log(s3.getCgpa())


class StudentV4 {
    constructor(private _name = "", private _cgpa = 0) {

    }
    get Name() {
        return this._name;
    }
    get Cgpa() {
        return this._cgpa;
    }
    set Name(name: string) {
        this._name = name;
    }
    set Cgpa(cgpa: number) {
        this._cgpa = cgpa;
    }
}
let s4 = new StudentV4("Subh", 8.7)
console.log(s4)
s4.Name = "Rahul"
console.log(s4)