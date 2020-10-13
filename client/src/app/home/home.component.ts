import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  registerMode = false;
  users: any;
  constructor(private title: Title){}

  ngOnInit(): void {
    this.title.setTitle('Home page');
  }
  registerToggle() {

    this.registerMode = !this.registerMode;
  }

  

  cancelRegisterMode(event: boolean) {

    this.registerMode = event;
  }

}