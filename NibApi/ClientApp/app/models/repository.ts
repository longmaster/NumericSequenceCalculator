import { Injectable } from "@angular/core";
import { Http, RequestMethod, Request, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";

import "rxjs/add/operator/map";
import 'rxjs/add/operator/filter';


const allNumberUrl = "/api/numbersquence/allnumber";
const evenNumberUrl = "/api/numbersquence/evennumber";
const oddNumberUrl = "/api/numbersquence/oddnumber";
const allNumberWCharacterUrl = "/api/numbersquence/AllNumberCharacter";


@Injectable()

export class Repository {

    constructor(private http:Http){
      
    }


    private sendRequest(verb: RequestMethod, url: string, data?: any): Observable<any> {
        return this.http.request(new Request({
            method: verb, url: url, body: data
        })).map(response => {
            return response.headers!.get("Content-Length") != "0"
                ? response.json() : null;
           
        });
    }

    getAllNumber(value: number) {
        this.sendRequest(RequestMethod.Get, allNumberUrl + "/" + value)
            .subscribe(response => this.allNumber = response);
       
    }

    getEvenNumber(value: number) {
        this.sendRequest(RequestMethod.Get, evenNumberUrl + "/" + value)
            .subscribe(response => this.evenNumber = response);

    }

    getOddNumber(value: number) {
        this.sendRequest(RequestMethod.Get, oddNumberUrl + "/" + value)
            .subscribe(response => this.oddNumber = response);

    }

    getAllNumberWithCharacter(value: number) {
        this.sendRequest(RequestMethod.Get, allNumberWCharacterUrl + "/" + value)
            .subscribe(response => this.allNumberWCharacter = response);

    }

    allNumber: number[]
    evenNumber: number[]
    oddNumber: number[]
    allNumberWCharacter: number[]
}

