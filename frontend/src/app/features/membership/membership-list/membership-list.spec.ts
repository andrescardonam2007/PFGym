import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MembershipList } from './membership-list';

describe('MembershipList', () => {
  let component: MembershipList;
  let fixture: ComponentFixture<MembershipList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MembershipList],
    }).compileComponents();

    fixture = TestBed.createComponent(MembershipList);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
