import { Component, OnInit } from '@angular/core';
import {IPerson} from "../models/person";
import {PersonService} from "../services/person.service";

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  persons : IPerson[];

  constructor(private personService: PersonService) {
  }

  ngOnInit() {
    this.personService.getPersons().subscribe( msg => {
      this.persons = msg;
    }, error1 => {
      console.log("error");
    })
  }


}
