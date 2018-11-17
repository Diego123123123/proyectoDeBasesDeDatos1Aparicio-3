import {Inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {IPerson} from "../models/person";

@Injectable()
export class PersonService {
  private serviceUrl = this.url + "persons";

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private url: string) { }

  getPersons(){
    // console.log(this.serviceUrl);
    return this.httpClient.get<IPerson[]>(this.serviceUrl);
  }

  savePerson(person: IPerson){
    return this.httpClient.post<IPerson>(this.serviceUrl, person);
  }

}
