import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { AdminpanelComponent } from './adminpanel.component';
import { Employee } from './Employee';

@Injectable({
  providedIn: 'root'
})
export class AdminpanelService {

  constructor(private httpClient: HttpClient) { }

  url: string = "api/user";
  urlRole: string = "api/roles";

  get(): Observable<Employee[]> {
    return this.httpClient.get<Employee[]>(this.url);
  }

  getRoles(): Observable<string[]> {
    return this.httpClient.get<string[]>(this.urlRole);
  }

  updateRole(emp: Employee, comp: AdminpanelComponent) {

    console.log(emp);

    return this.httpClient.put(this.url, emp).subscribe(res => {
      comp.ngOnInit();
    });
  }

  
}
