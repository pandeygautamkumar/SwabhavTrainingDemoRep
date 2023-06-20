interface ICustomer {    // Schema
    id: number,
    firstName: string,
    lastName: string,
    location?: string
}

// let customers: Array<ICustomer>;

let customers: ICustomer[];
customers = [
    { id: 101, firstName: "Customer 1", lastName: "LastName" },
    { id: 102, firstName: "Customer 2", lastName: "LastName" },
    { id: 103, firstName: "Customer 3", lastName: "LastName" },
    { id: 104, firstName: "Customer 4", lastName: "LastName", location: "Mumbai" }
];

printDetails(customers);

function printDetails(customers: ICustomer[]) {
    for (let c in customers)  //Index
    {
        console.log(c)
    }
    for (let c of customers)  // Value of
    {
        console.log(c.firstName)
    }
}