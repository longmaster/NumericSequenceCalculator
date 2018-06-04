import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Repository } from './../../models/repository';
import { NgModule } from "@angular/core"

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {


    constructor(private repo: Repository) { }

    value = '';


    onKey(event: any, input: any) { // without type info
  
        if (this.value != event.target.value && input == true) {
        
            this.repo.getAllNumber(event.target.value);
            this.repo.getEvenNumber(event.target.value);
            this.repo.getOddNumber(event.target.value);
            this.repo.getAllNumberWithCharacter(event.target.value);

            this.value = event.target.value;
        }

    }

    get allNumber(): number[] {
        return this.repo.allNumber;
    }

    get oddNumber(): number[] {
        return this.repo.oddNumber;
    }

    get evenNumber(): number[] {
        return this.repo.evenNumber;
    }

    get allNumberWithCharacter(): number[] {
        return this.repo.allNumberWCharacter;
    }
}
