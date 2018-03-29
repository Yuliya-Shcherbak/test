export class Client {
    constructor(clientID: number, firstName: string, lastName: string, address: string, phones: string) {
        this.ClientID = clientID;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
        this.Phones = phones;
    }

    ClientID: number;
    public FirstName: string;
    public LastName: string;
    public Address: string;
    public Phones: string;
}