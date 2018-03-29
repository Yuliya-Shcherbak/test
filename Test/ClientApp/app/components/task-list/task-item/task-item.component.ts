import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { DatePipe } from '@angular/common';

import { Task } from '../../../models/task';
import { ApiService } from '../../../services/api.service';

@Component({
  selector: 'app-task-item',
  templateUrl: './task-item.component.html',
  styleUrls: ['./task-item.component.css']
})
export class TaskItemComponent implements OnInit {

    @Input() taskItem: Task;
    @Output() taskDeleted = new EventEmitter<Task>();

    constructor(private apiService: ApiService) { }

    ngOnInit() {
    }

    deleteTask(id: number) {
        this.apiService.deleteTask(id)
            .subscribe(() => {
                this.taskDeleted.emit(this.taskItem);
            });
    }
}
