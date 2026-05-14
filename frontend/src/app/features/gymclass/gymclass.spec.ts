import { TestBed } from '@angular/core/testing';

import { Gymclass } from './gymclass';

describe('Gymclass', () => {
  let service: Gymclass;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Gymclass);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
