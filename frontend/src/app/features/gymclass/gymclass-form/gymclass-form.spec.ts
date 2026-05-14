import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GymclassForm } from './gymclass-form';

describe('GymclassForm', () => {
  let component: GymclassForm;
  let fixture: ComponentFixture<GymclassForm>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GymclassForm],
    }).compileComponents();

    fixture = TestBed.createComponent(GymclassForm);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
