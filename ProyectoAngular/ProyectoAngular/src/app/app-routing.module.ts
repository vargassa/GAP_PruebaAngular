import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

//llamo por cada componente
import { StudentsGradeComponent } from "./students-grade/students-grade.component"

const routes: Routes = [{ path: '', component: StudentsGradeComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
