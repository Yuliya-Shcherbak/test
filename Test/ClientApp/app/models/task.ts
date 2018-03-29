export class Task {
    constructor(taskID: number, taskName: string, description: string, clientAddress: string, startDate: Date, endDate: Date) {
        this.TaskID = taskID;
        this.TaskName = taskName;
        this.ClientAddress = clientAddress;
        this.Description = description;
        this.StartDate = startDate;
        this.EndDate = endDate;
    }

    TaskID: number;
    public TaskName: string;
    public Description: string;
    public ClientAddress: string;
    public StartDate: Date;
    public EndDate: Date;
}