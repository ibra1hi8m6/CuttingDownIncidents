import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HierarchyService } from '../../services/hierarchy.service';



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

  selectedGovernrate?: number;
  selectedSector?: number;
  selectedZone?: number;
  selectedCity?: number;
  selectedStation?: number;
  selectedTower?: number;
  selectedCabin?: number;

  constructor(private hierarchyService: HierarchyService) {}

  ngOnInit(): void {
    this.loadGovernrates();
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
}
