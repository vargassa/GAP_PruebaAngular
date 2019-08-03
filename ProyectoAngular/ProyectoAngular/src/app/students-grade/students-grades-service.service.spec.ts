import { TestBed } from '@angular/core/testing';

import { StudentsGradesServiceService } from './students-grades-service.service';

describe('StudentsGradesServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StudentsGradesServiceService = TestBed.get(StudentsGradesServiceService);
    expect(service).toBeTruthy();
  });
});
