// hierarchy.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class HierarchyService {
  private baseUrl = `${environment.apiurl}/hierarchy`; // Replace with your actual API URL

  constructor(private http: HttpClient) { }

  getGovernrates(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/governrates`);
  }

  getSectors(governrateKey: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/sectors/${governrateKey}`);
  }

  getZones(sectorKey: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/zones/${sectorKey}`);
  }

  getCities(zoneKey: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/cities/${zoneKey}`);
  }

  getStations(cityKey: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/stations/${cityKey}`);
  }

  getTowers(stationKey: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/towers/${stationKey}`);
  }

  getCabins(towerKey: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/cabins/${towerKey}`);
  }

  getCables(cabinKey: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/cables/${cabinKey}`);
  }
}
