import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/services/student.model';
import { StudentlocalstorageService } from 'src/app/services/studentlocalstorage.service';

@Component({
  selector: 'app-display-student',
  templateUrl: './display-student.component.html',
  styleUrls: ['./display-student.component.css']
})
export class DisplayStudentComponent implements OnInit{
  students: Student[]=[];

  constructor(private studentLocalStorageService: StudentlocalstorageService) { }
  ngOnInit(): void {
    this.getStudents();
    // Listen for studentAdded event and update students array
    this.studentLocalStorageService.studentAdded.subscribe(() => {
      this.getStudents();
    });
  }

  getStudents(): void {
    this.studentLocalStorageService.getStudents().subscribe((students) => {
      this.students = students;
    });
  }
  
  confirmDelete(student: Student): void {
    if (confirm('Are you sure you want to delete the row?')) {
      this.deleteStudent(student);
    }
  }
  
  deleteStudent(student: Student): void {
    this.studentLocalStorageService.deleteStudent(student).subscribe(() => {
      this.getStudents();
    });
  }
}
