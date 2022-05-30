import { Component, OnInit } from '@angular/core';
import { Premiership } from 'src/app/shared/premiership.model';
import { PremiershipService } from 'src/app/shared/premiership.service';

@Component({
  selector: 'app-player-form',
  templateUrl: './player-form.component.html',
  styles: [
  ]
})
export class PlayerFormComponent implements OnInit {

  constructor(public service:PremiershipService) { }

  ngOnInit(): void {
  }

}
