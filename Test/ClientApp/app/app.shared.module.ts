import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';

import { Client } from './models/client';
import { Task } from './models/task';

import { ClientItemComponent } from './components/client-list/client-item/client-item.component';
import { ClientListComponent } from './components/client-list/client-list.component';
import { TaskEmptyComponent } from './components/task-list/task-empty/task-empty.component';
import { TaskItemComponent } from './components/task-list/task-item/task-item.component';
import { TaskListComponent } from './components/task-list/task-list.component';

import { ApiService } from './services/api.service'
import { FilterPipe } from './pipes/filter.pipe';
import { filterQueryId } from '@angular/core/src/view/util';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        ClientItemComponent,
        ClientListComponent,
        TaskEmptyComponent,
        TaskItemComponent,
        TaskListComponent,
        FilterPipe
    ],
    providers: [
        ApiService
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: '/home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent, children: [
                    { path: '', component: TaskEmptyComponent },
                    { path: ':id', component: TaskListComponent }
                ]
            },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
