import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HierarchyService } from '../../services/hierarchy.service';
import { ApiService } from '../../services/api.service';



@Component({
  selector: 'app-add',
standalone:true,
  imports: [CommonModule, FormsModule, HttpClientModule],
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent implements OnInit  {
  governrates: any[] = [];
  sectors: any[] = [];
  zones: any[] = [];
  cities: any[] = [];
  stations: any[] = [];
  towers: any[] = [];
  cabins: any[] = [];
  cables: any[] = [];
  problemTypes: any[] = [];
  networkHierarchyPaths: any[] = [];
  networkElementTypes: any[] = [];
  selectedGovernrate?: number;
  selectedSector?: number;
  selectedZone?: number;
  selectedCity?: number;
  selectedStation?: number;
  selectedTower?: number;
  selectedCabin?: number;
  selectedHierarchyPath?: string;
    selectedProblemType?: number;
  selectedDate?: string;
  impactedCustomers?: number;
  constructor(private hierarchyService: HierarchyService,
              private apiService: ApiService) {}

  ngOnInit(): void {
    this.loadGovernrates();
    this.loadHierarchyPaths();
    this.loadProblemTypes();
    this.loadNetworkElementTypes();
  }
    loadProblemTypes() {
    this.apiService.getProblemTypes().subscribe({
      next: (data) => (this.problemTypes = data),
      error: (err) => console.error('Error loading problem types', err),
    });
  }
   loadNetworkElementTypes() {
    this.apiService.getNetworkElementTypes().subscribe({
      next: (data) => (this.networkElementTypes = data),
      error: (err) => console.error('Error loading network element types', err),
    });
  }
  loadHierarchyPaths() {
    this.apiService.getNetworkHierarchyPaths()
      .subscribe(data => this.networkHierarchyPaths = data);
  }
  loadGovernrates() {
    this.hierarchyService.getGovernrates().subscribe(data => this.governrates = data);
  }

  selectGovernrate(governrateKey: number) {
    this.selectedGovernrate = governrateKey;
    this.sectors = [];

    if (governrateKey) {
      this.hierarchyService.getSectors(governrateKey).subscribe(data => this.sectors = data);
    }
  }

  selectSector(sectorKey: number) {
    this.selectedSector = sectorKey;
    this.zones = [];

    if (sectorKey) {
      this.hierarchyService.getZones(sectorKey).subscribe(data => {this.zones = data});

    }
  }

  selectZone(zoneKey: number) {
    this.selectedZone = zoneKey;
    this.cities = [];

    if (zoneKey) {
      this.hierarchyService.getCities(zoneKey).subscribe(data => this.cities = data);
    }
  }

  selectCity(cityKey: number) {
    this.selectedCity = cityKey;
    this.stations = [];

    if (cityKey) {
      this.hierarchyService.getStations(cityKey).subscribe(data => this.stations = data);
    }
  }

  selectStation(stationKey: number) {
    this.selectedStation = stationKey;
    this.towers = [];

    if (stationKey) {
      this.hierarchyService.getTowers(stationKey).subscribe(data => this.towers = data);
    }
  }

  selectTower(towerKey: number) {
    this.selectedTower = towerKey;
    this.cabins = [];

    if (towerKey) {
      this.hierarchyService.getCabins(towerKey).subscribe(data => this.cabins = data);
    }
  }

  selectCabin(cabinKey: number) {
    this.selectedCabin = cabinKey;
    this.cables = [];
    if (cabinKey) {
      this.hierarchyService.getCables(cabinKey).subscribe(data => this.cables = data);
    }
  }

   addIncident() {
    if (!this.selectedProblemType || !this.selectedDate || !this.impactedCustomers) {
      alert("Please fill all required fields");
      return;
    }

    // Take selected network element (last selected node)
    const networkElementKey = this.selectedCabin
      || this.selectedTower
      || this.selectedStation
      || this.selectedCity
      || this.selectedZone
      || this.selectedSector
      || this.selectedGovernrate;

    if (!networkElementKey) {
      alert("Please select a network element from hierarchy");
      return;
    }

    // Get user from local storage
    const createdUser = localStorage.getItem("userKey") || "unknown";

    const dto = {
      cutting_Down_Problem_Type_Key: this.selectedProblemType,
      actualCreatetDate: this.selectedDate,
      network_Element_Key: networkElementKey,
      impactedCustomers: this.impactedCustomers,
      createdUser: createdUser
    };

    this.apiService.createIncident(dto).subscribe({
      next: (res) => {
        console.log("Incident created:", res);
        alert("Incident created successfully!");
        this.resetForm();
      },
      error: (err) => {
        console.error("Error creating incident", err);
        alert("Failed to create incident");
      }
    });
  }

  resetForm() {
    this.selectedProblemType = undefined;
    this.selectedDate = undefined;
    this.impactedCustomers = undefined;
    this.selectedGovernrate = undefined;
    this.selectedSector = undefined;
    this.selectedZone = undefined;
    this.selectedCity = undefined;
    this.selectedStation = undefined;
    this.selectedTower = undefined;
    this.selectedCabin = undefined;
  }
}
