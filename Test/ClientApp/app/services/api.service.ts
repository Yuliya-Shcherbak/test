import { Inject, Injectable } from "@angular/core";
import { Http } from "@angular/http";
import { Subject } from "rxjs/Subject";

import { Client } from '../models/client';
import { Task } from '../models/task';

@Injectable()
export class ApiService {

    url: string;

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) { }

    getItemID = new Subject();

    generateUrl(path: string): string {
        return this.baseUrl + path;
    }
    
    getAllClients() { 
        this.url = this.generateUrl('/api/clients/getAllClients');
        return this.http.get(this.url);
    }

    getAllClientTasks(id: number) {
        this.url = this.generateUrl('/api/tasks/getClientTasks/' + id);
        return this.http.get(this.url);
    }

    deleteTask(id: number) {
        this.url = this.generateUrl('/api/tasks/deleteTask/' + id);
        return this.http.delete(this.url);
    }
}
