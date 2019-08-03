import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 
import { StudentGradesClass } from './StudentGrades';
import { StudentsGradesServiceService } from './students-grades-service.service';
import { debug } from 'util';

@Component({
  selector: 'app-students-grade',
  templateUrl: './students-grade.component.html',
  styleUrls: ['./students-grade.component.css']  
})
export class StudentsGradeComponent implements OnInit {

  nametoFilter: string="";
  idScore: number = 0;
  idCourse: string="";

  lista: StudentGradesClass[];

  constructor(private SRV: StudentsGradesServiceService) {    
  }

  ngOnInit() {
    document.getElementById('idCourse').style.display = 'none';
       document.getElementById('idScore').style.display = 'none';
    this.SRV.GetAllStudentsService().subscribe((resp)=>{
      this.lista =resp;
      } );
  }

 FilterStudentByName()
 {
      this.nametoFilter = (<HTMLInputElement>document.getElementById('idNameOfStudent')).value;

      if(document.getElementById('idCourse').style.display == 'none' &&
        document.getElementById('idScore').style.display == 'none')
      {
        this.SRV.FilterStudentsByName(this.nametoFilter).subscribe((resp)=>{
          this.lista =resp;
          } );  
      }else if(document.getElementById('idCourse').style.display == 'none')
      {                
        this.idScore = parseInt((<HTMLInputElement>document.getElementById('idScore')).value);

        debugger;
        if(Number.isNaN(this.idScore))
        { 
          this.idScore = 0;
        }

        this.SRV.FilterStudentsByNameAndScore(this.nametoFilter, this.idScore).subscribe((resp)=>{
          this.lista =resp;
          } );  
      }else
      {
        this.idScore = parseInt((<HTMLInputElement>document.getElementById('idScore')).value);
        this.idCourse = (<HTMLInputElement>document.getElementById('idCourse')).value;
        
        if(Number.isNaN(this.idScore))
        { 
          this.idScore = 0;
        }

        this.SRV.FilterByAllOptions(this.nametoFilter, this.idScore, this.idCourse).subscribe((resp)=>{
          this.lista =resp;
          } ); 
      }
 }

 HideFilter1()
 {
       document.getElementById('idCourse').style.display = 'none';
       document.getElementById('idScore').style.display = 'none';       
 }

 HideFilter2()
 {
       document.getElementById('idCourse').style.display = 'none';
       document.getElementById('idScore').style.display = '';
 }

 HideFilter3()
 {
       document.getElementById('idCourse').style.display = '';
       document.getElementById('idScore').style.display = '';
 }

 ClearFilters()
 {
      (<HTMLInputElement>document.getElementById('idScore')).value = '';
      (<HTMLInputElement>document.getElementById('idCourse')).value = '';
      (<HTMLInputElement>document.getElementById('idNameOfStudent')).value = '';
 }

}
