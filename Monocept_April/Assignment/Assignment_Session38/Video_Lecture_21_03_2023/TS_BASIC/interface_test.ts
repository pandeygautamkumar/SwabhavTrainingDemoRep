interface ICustomer {
    id: number,
    firstName: string,
    lastName: string,
    location?: string
}

let customers: Array<ICustomer> = [{ id: 101, firstName: "abc", lastName: "pqr" },
{ id: 102, firstName: "def", lastName: "stuv", location: "Mumbai" }
];

printDetails(customers);

function printDetails(pcustomer: ICustomer[]) {
    /*for (let index in pcustomer) {   //Index
        console.log(index)
    }
    for (let customer of pcustomer) {
        console.log(customer)
    }*/
    for (let index in customers) {   //Index
        console.log(index)
    }
    for (let customer of customers) {
        console.log(customer)
    }
}

