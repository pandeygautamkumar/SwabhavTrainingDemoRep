class studentV1 {
    name: string
    cgpa: number

    constructor(pname = "Anonymous", pcgpa = 0) {
        this.name = pname;
        this.cgpa = pcgpa;
    }
}


let s1: studentV1;
s1 = new studentV1();

s1.name = "Ekta"
s1.cgpa = 7.5

console.log(s1)



class StudentV2 {
    constructor(public name = "Anonymous", public cgpa = 0) {
    }
}

let s2 = new StudentV2();
console.log(s2)
s2.cgpa = 7.0
s2.name = 'Manjunath'
console.log(s2)



class StudentV3 {
    constructor(private name = "", private cgpa = 0) {    //Part Of Property if Use Public ,Private

    }
    setUserName(pname: string) {
        this.name = pname;
    }
    getUserName() {
        return this.name;
    }
    setUserCgpa(pcgpa: number) {
        this.cgpa = pcgpa;
    }
    getUserCgpa() {
        return this.cgpa;
    }
}
let s3 = new StudentV3()
console.log(s3)
s3.setUserCgpa(9)
s3.setUserName("Gautam")
console.log(s3)



class StudentV4 {
    constructor(private name = "", private cgpa = 0) {

    }
    get UserName() {
        return this.name;
    }
    set UserName(pname: string) {
        this.name = pname;
    }
    get UserCgpa() {
        return this.cgpa;
    }
    set UserCgpa(pcgpa: number) {
        this.cgpa = pcgpa;
    }
}

let s4 = new StudentV4();
s4.UserName = "Anikant"
s4.UserCgpa = 8
console.log(s4)