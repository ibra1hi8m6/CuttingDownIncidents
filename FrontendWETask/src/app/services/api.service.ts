import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
private baseUrl = `${environment.apiurl}/incidents`;
  constructor(private http: HttpClient) { }

  getProblemTypes(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/GetProblemTypes`);
  }

  getChannels(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/Channels`);
  }

  getNetworkElementTypes(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/NetworkElementTypes`);
  }
  getNetworkHierarchyPaths(): Observable<any[]> {
  return this.http.get<any[]>(`${this.baseUrl}/NetworkElementHierarchyPath`);
}

}
