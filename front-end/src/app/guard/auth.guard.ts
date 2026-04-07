import { CanActivateFn, Router } from '@angular/router';
import { inject } from '@angular/core';

export const authGuard: CanActivateFn = () => {
  const router = inject(Router);

  const isLogged = localStorage.getItem('isLoggedIn') === 'true';

  if (!isLogged) {
    router.navigate(['/']);
    return false;
  }

  return true;
};