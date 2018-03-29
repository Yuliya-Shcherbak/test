import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Task } from '../../models/task';
import { ApiService } from '../../services/api.service';
import { equalParamsAndUrlSegments } from '@angular/router/src/router_state';
import { Params } from '@angular/router/src/shared';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

    tasks: Task[];

    constructor(private apiService: ApiService,
                private route: ActivatedRoute) { }

    ngOnInit() {
        this.route.params
            .subscribe((params: Params) => {
                this.apiService.getAllClientTasks(params['id'])
                    .subscribe(data => {
                    this.tasks = data.json() as Task[]
                });
            });
    }

    onListItemDeleted(item: Task) {
        const index: number = this.tasks.indexOf(item);
        if (index !== -1) {
            this.tasks.splice(index, 1);
        }
    }
}
