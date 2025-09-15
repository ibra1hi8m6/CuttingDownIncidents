import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ApiService } from '../../services/api.service';
interface CuttingDownDetail {
  Cutting_Down_Key: number;
  Network_Element_Key?: number;
  ImpactedCustomers?: number;
  ActualCreatetDate?: string;
}
@Component({
  selector: 'app-search',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent implements OnInit {
  problemTypes: any[] = [];
  channels: any[] = [];
  networkElementTypes: any[] = [];

  searchResult: any = { headers: [], details: [], totalCount: 0, pageNumber: 1, pageSize: 20 };
  flattenedRows: any[] = [];

  // filter matches CuttingDownSearchFilter (only needed props)
  filter: any = {
    ChannelKey: null,
    ProblemTypeKey: null,
    Status: '',
    SearchValue: '',
    NetworkElementTypeKey: null, // keep null as requested
    PageNumber: 1,
    PageSize: 20
  };

  constructor(private apiService: ApiService) {}

  ngOnInit(): void {
    this.loadProblemTypes();
    this.loadChannels();
    this.loadNetworkElementTypes();
  }

  loadProblemTypes() {
    this.apiService.getProblemTypes().subscribe({
      next: (data) =>  {
      this.problemTypes = data;
      console.log('Problem types loaded:', this.problemTypes);
    },
      error: (err) => console.error('Error loading problem types', err),
    });
  }

  loadChannels() {
    this.apiService.getChannels().subscribe({
      next: (data) =>  {
      this.channels = data;
      console.log('Channels loaded:', this.channels);
    },
      error: (err) => console.error('Error loading channels', err),
    });
  }

  loadNetworkElementTypes() {
    this.apiService.getNetworkElementTypes().subscribe({
      next: (data) => 
       {
      this.networkElementTypes = data;
      console.log('Network Element Type loaded:', this.networkElementTypes);
    },
      error: (err) => console.error('Error loading network element types', err),
    });
  }
  onProblemTypeChange(event: any) {
    this.filter.ProblemTypeKey = event?.target?.value || null;
  }
  onSearch() {
    console.log('Filter being sent:', this.filter);
    this.apiService.searchIncidents(this.filter).subscribe({
      next: (res) => {
        this.searchResult = res;
        this.buildFlattenedRows();
        console.log('Search result:', res);
      },
      error: (err) => console.error('Search error', err)
    });
  }

  private buildFlattenedRows(): void {
    this.flattenedRows = [];
    const headers = this.searchResult.headers || [];
    const details = this.searchResult.details || [];

    for (const h of headers) {
      const headerKey = h.Cutting_Down_Key;

      // find matching details by Cutting_Down_Key
       const matchingDetails = details.filter(
      (d: CuttingDownDetail) => d.Cutting_Down_Key === headerKey
    );

      if (matchingDetails.length > 0) {
        for (const d of matchingDetails) {
          this.flattenedRows.push({
            Cutting_Down_Key: h.Cutting_Down_Key,
            Cutting_Down_Incident_ID: h.Cutting_Down_Incident_ID,
            Channel_Key: h.Channel_Key,
            ProblemType_Key: h.ProblemType_Key,
            Status: h.Status,
            PlannedStartDTS: h.PlannedStartDTS,
            PlannedEndDTS: h.PlannedEndDTS,
            CreatedUser: h.CreatedUser,
            IsActive: h.IsActive,
            IsGlobal: h.IsGlobal,
            IsPlanned: !!h.PlannedStartDTS,

            NetworkElement: d.Network_Element_Key,
            ImpactedCustomers: d.ImpactedCustomers,
            DetailCreatedDate: d.ActualCreatetDate
          });
        }
      } else {
        // header only
        this.flattenedRows.push({
          Cutting_Down_Key: h.Cutting_Down_Key,
          Cutting_Down_Incident_ID: h.Cutting_Down_Incident_ID,
          Channel_Key: h.Channel_Key,
          ProblemType_Key: h.ProblemType_Key,
          Status: h.Status,
          PlannedStartDTS: h.PlannedStartDTS,
          PlannedEndDTS: h.PlannedEndDTS,
          CreatedUser: h.CreatedUser,
          IsActive: h.IsActive,
          IsGlobal: h.IsGlobal,
          IsPlanned: !!h.PlannedStartDTS,

          NetworkElement: '',
          ImpactedCustomers: '',
          DetailCreatedDate: ''
        });
      }
    }
  }


getDetailsForHeader(headerKey: number) {
  return this.searchResult.details.filter((d: CuttingDownDetail) => d.Cutting_Down_Key === headerKey);
}


}
