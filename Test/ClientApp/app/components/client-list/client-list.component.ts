import { Component, OnInit } from '@angular/core';

import { Client } from '../../models/client';
import { ApiService } from '../../services/api.service';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styleUrls: ['./client-list.component.css']
})
export class ClientListComponent implements OnInit { 

    clients: Client[]; 
    searchString: string;
    selectedFilter: string = "firstName";

    constructor(private apiService: ApiService ) { }

    ngOnInit() {
        this.apiService.getAllClients()
            .subscribe(data => {
            this.clients = data.json() as Client[];
        }, error => console.error(error));
    }    

    options = ["by Name", "by Address"];
    optionSelected: any;

    onOptionSelected(value: string) {
        if (value === "by Name") {
            this.selectedFilter = "firstName";
        } else {
            this.selectedFilter = "address";
        }
    }
}
