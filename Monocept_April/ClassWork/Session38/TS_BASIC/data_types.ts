let userName: string,
    cgpa: number,
    isMale: boolean,
    displayText: string;

userName = "Sachin";
cgpa = 7.5;
isMale = true;

displayText = `
                        ============================ 
                            Showing Student Details  
                        ============================
                        User Name is ${userName}
                        CGPA : ${cgpa}  
                        Gender is : ${isMale}?"Male":"Female"     
                `

console.log(displayText)
