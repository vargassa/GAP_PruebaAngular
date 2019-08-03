import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
import { HttpClient } from '@angular/common/http'; 
import { StudentGradesClass } from './StudentGrades'; 
import { debug } from 'util';

@Injectable({
  providedIn: 'root'
})
export class StudentsGradesServiceService {

  constructor(private http: HttpClient){}

  GetAllStudentsService()
  {
    let headers = new HttpHeaders()
            .set('Access-Control-Allow-Methods', 'POST, GET, OPTIONS, DELETE, PUT')
            .set('content-type', 'application/json')
            .set('dataType', 'json')
            .set('Access-Control-Allow-Origin', 'http://localhost:4200');
              

    return this.http.get<StudentGradesClass[]>('http://localhost:38301/api/StudentGrades/') 
  }

  FilterStudentsByName (name: string)
  {
    return this.http.get<StudentGradesClass[]>('http://localhost:38301/api/StudentGrades?pName='  + name )     
  } 

  FilterStudentsByNameAndScore (name: string, score: number)
  {    
    return this.http.get<StudentGradesClass[]>('http://localhost:38301/api/StudentGrades?pName='+ name 
                                                  + '&pScore=' + score )     
  } 

  FilterByAllOptions(name: string, score: number, course : string)
  {
    return this.http.get<StudentGradesClass[]>('http://localhost:38301/api/StudentGrades?pName='+ name 
                                                  + '&pScore=' + score + '&pCourse=' + course )     
  } 

}
