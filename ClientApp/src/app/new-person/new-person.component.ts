import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup} from "@angular/forms";
import {IPerson} from "../models/person";
import {PersonService} from "../services/person.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-new-person',
  templateUrl: './new-person.component.html',
  styleUrls: ['./new-person.component.css']
})
export class NewPersonComponent implements OnInit {

  constructor(private fb: FormBuilder, private personService: PersonService, private router: Router) { }
  formGroup : FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      name: '',
      lastName: ''
    });
  }
  save(){
    let person: IPerson = Object.assign({}, this.formGroup.value);
    console.table(person);
    this.personService.savePerson(person).subscribe(p => this.onSaveSuccess(),
      error1 => console.log("error"))
  }

  onSaveSuccess(){
    this.router.navigate(["/persons"])
  }

}
