import { Component } from '@angular/core';
import { IDomain } from './domain';
import { DomainsService } from './domains.service';

@Component({
  selector: 'app-domains',
  templateUrl: './domains.component.html'
})

export class DomainsComponent {
  public domains: IDomain[] = [];

  constructor(private _domainService: DomainsService) { }

  ngOnInit() {
    this._domainService.getDomains().subscribe(
      (result) => {
        this.domains = result;
      },
      (error) => {
        console.error(error);
      });
  }
}
