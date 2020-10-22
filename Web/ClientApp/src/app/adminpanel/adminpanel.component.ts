import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../home/auth.service';
import { AdminpanelService } from './adminpanel.service';
import { Employee } from './Employee';

@Component({
  selector: 'app-adminpanel',
  templateUrl: './adminpanel.component.html',
  styleUrls: ['./adminpanel.component.css']
})
export class AdminpanelComponent implements OnInit {

  constructor(private service: AdminpanelService, private as: AuthService, private router: Router) { }

  users: Employee[];
  roles: string[];
  selectedId = null;
  selectedRole= "";

  ngOnInit(): void {

    //if (!this.as.isAuthenticated)
    //  this.router.navigate(['']);

    this.service.getRoles().subscribe(data => {
      console.log(data);
      this.roles = data;
    });

    this.service.get().subscribe(data => {
      console.log(data);
      this.users = data;
    });
  }

  selectChangeHandler(event: any) {
    //update the ui
    this.selectedRole = event.target.value;

    var data = this.selectedRole.split(':');
    data[1] = data[1].replace(" ", "");

    var emp = this.users.find(x => x.id == Number(data[1]));

    if (emp.role != this.roles[Number(data[0])]) {
      emp.role = this.roles[Number(data[0])];
      this.service.updateRole(emp, this);
    }
  }
}
