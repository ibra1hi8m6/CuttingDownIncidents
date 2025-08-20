import { Component, OnInit  } from '@angular/core';
import { ApiService } from '../../services/api.service';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-search',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent implements OnInit {
  problemTypes: any[] = [];
  channels: any[] = [];
  networkElementTypes: any[] = [];

  constructor(private apiService: ApiService) {}

  ngOnInit(): void {
    this.loadProblemTypes();
    this.loadChannels();
    this.loadNetworkElementTypes();
  }

  loadProblemTypes() {
    this.apiService.getProblemTypes().subscribe({
      next: (data) => (this.problemTypes = data),
      error: (err) => console.error('Error loading problem types', err),
    });
  }

  loadChannels() {
    this.apiService.getChannels().subscribe({
      next: (data) => (this.channels = data),
      error: (err) => console.error('Error loading channels', err),
    });
  }

  loadNetworkElementTypes() {
    this.apiService.getNetworkElementTypes().subscribe({
      next: (data) => (this.networkElementTypes = data),
      error: (err) => console.error('Error loading network element types', err),
    });
  }
}

