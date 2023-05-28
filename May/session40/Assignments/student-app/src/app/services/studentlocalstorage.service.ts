import { HttpClient } from '@angular/common/http';
import { EventEmitter, Injectable } from '@angular/core';
import { Observable, map, of, take } from 'rxjs';
import { Student } from './student.model';

@Injectable({
  providedIn: 'root'
})
export class StudentlocalstorageService {
  private readonly KEY = 'students';
  // Define studentAdded event
  studentAdded = new EventEmitter<void>();

  constructor() {}

  addStudent(student: Student): Observable<void> {
    return this.getStudents().pipe(
      take(1),
      map((students) => {
        students.push(student);
        localStorage.setItem(this.KEY, JSON.stringify(students));
        // Emit studentAdded event
        this.studentAdded.emit();
      })
    );
  }

  getStudents(): Observable<Student[]> {
    const students = JSON.parse(localStorage.getItem(this.KEY)!);
    return of(students || []);
  }

  deleteStudent(student: Student): Observable<void> {
    return this.getStudents().pipe(
      map((students) => {
        const index = students.findIndex((s) => s.firstName === student.firstName && s.lastName === student.lastName && s.cgpa === student.cgpa);
        if (index !== -1) {
          students.splice(index, 1);
          localStorage.setItem(this.KEY, JSON.stringify(students));
        }
      })
    );
  }
}
