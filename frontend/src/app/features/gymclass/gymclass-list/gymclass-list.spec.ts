import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GymclassList } from './gymclass-list';

describe('GymclassList', () => {
  let component: GymclassList;
  let fixture: ComponentFixture<GymclassList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GymclassList],
    }).compileComponents();

    fixture = TestBed.createComponent(GymclassList);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
