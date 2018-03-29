import { Component, OnInit, Input } from '@angular/core';

import { Client } from '../../../models/client';
import { ApiService } from '../../../services/api.service';

@Component({
  selector: 'app-client-item',
  templateUrl: './client-item.component.html',
  styleUrls: ['./client-item.component.css']
})
export class ClientItemComponent implements OnInit {

    @Input() clientID: number;
    @Input() clientItem: Client;   
        
    constructor( private apiService: ApiService ) { }

    ngOnInit() {
    }   
}
