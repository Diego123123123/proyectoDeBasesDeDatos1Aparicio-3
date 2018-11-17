import {Inject, Injectable} from '@angular/core';
import {IPerson} from "../models/person";
import {HttpClient} from "@angular/common/http";
import {IMateria} from "../models/Materia";

@Injectable()
export class MateriaService {
  private serviceUrl = this.url + "materias";

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private url: string) { }

  getMaterias(){
    return this.httpClient.get<IMateria[]>(this.serviceUrl);
  }

  saveMaterias(materia: IMateria){
    return this.httpClient.post<IMateria>(this.serviceUrl, materia);
  }
}
