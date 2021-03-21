import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-server-error',
  templateUrl: './server-error.component.html',
  styleUrls: ['./server-error.component.scss']
})
export class ServerErrorComponent implements OnInit {
  error: any;

  constructor(private router: Router) { 
    // this can be done only in ctor and not in ngoninit()
    const navigation = this.router.getCurrentNavigation();
    // optional chaining
    this.error = navigation?.extras?.state?.error;
  }

  ngOnInit(): void {
  }

}
