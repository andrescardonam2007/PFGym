import { Routes } from '@angular/router';

import { MemberList } from './features/member/member-list/member-list';
import { TrainerList } from './features/trainer/trainer-list/trainer-list';
import { GymclassList } from './features/gymclass/gymclass-list/gymclass-list';
import { MembershipList } from './features/membership/membership-list/membership-list';
import { DashboardHome } from './features/dashboard/dashboard-home/dashboard-home';

export const routes: Routes = [
  {
    path: '',
    component: DashboardHome
  },
  {
    path: 'members',
    component: MemberList
  },
  {
    path: 'trainers',
    component: TrainerList
  },
  {
    path: 'classes',
    component: GymclassList
  },
  {
    path: 'memberships',
    component: MembershipList
  }
];