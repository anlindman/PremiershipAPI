import { Injectable } from '@angular/core';
import { Player } from './player.model';

@Injectable({
  providedIn: 'root'
})
export class PremiershipService {

  constructor() { }

  formData: Player = new Player();
}
