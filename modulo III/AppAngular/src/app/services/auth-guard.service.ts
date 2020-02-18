import { Injectable } from '@angular/core';
import { CanLoad, CanActivate } from '@angular/router';

@Injectable()
export class AuthGuardService implements CanLoad, CanActivate {

  canLoad(): boolean {
    return true;
  }

  canActivate(): boolean {
    return true;
  }


}
