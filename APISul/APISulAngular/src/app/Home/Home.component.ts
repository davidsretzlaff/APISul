import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@ANGULAR/common/http';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private http: HttpClient) { }

  andarMenosUtilizado: {};
  periodoMariorFluxoElevadorMaisFrequentado: {};
  periodoMenorFluxoElevadorMenosFrequentado: {};
  periodoMaiorUtilizacaoConjuntoElevadores: {};
  elevadorMaisFrequentado: {};
  elevadorMenosFrequentado: {};
  percentualA: {};
  percentualB: {};
  percentualC: {};
  percentualD: {};
  percentualE: {};

  ngOnInit() {
    this.getAndarMenosUtilizado();
    this.getElevadorMaisFrequentado();
    this.getPeriodoMaiorUtilizacaoConjuntoElevadores();
    this.getPeriodoMariorFluxoElevadorMaisFrequentado();
    this.getElevadorMenosFrequentado();
    this.getPeriodoMenorFluxoElevadorMenosFrequentado();
    this.getPercentualA();
    this.getPercentualB();
    this.getPercentualC();
    this.getPercentualD();
    this.getPercentualE();
  }

  getAndarMenosUtilizado() {
    this.http.get('http://localhost:5000/api/Elevator/andarMenosUtilizado').subscribe
      (
        response => { this.andarMenosUtilizado = response; },
        error => { console.log(error); }
      );
  }
  getElevadorMaisFrequentado() {
    this.http.get('http://localhost:5000/api/Elevator/elevadorMaisFrequentado').subscribe
      (
        response => { this.elevadorMaisFrequentado = response; },
        error => { console.log(error); }
      );
  }
  getElevadorMenosFrequentado() {
    this.http.get('http://localhost:5000/api/Elevator/elevadorMenosFrequentado').subscribe
      (
        response => { this.elevadorMenosFrequentado = response; },
        error => { console.log(error); }
      );
  }
  getPeriodoMariorFluxoElevadorMaisFrequentado() {
    this.http.get('http://localhost:5000/api/Elevator/periodoMaiorFluxoElevadorMaisFrequentado').subscribe
      (
        response => { this.periodoMariorFluxoElevadorMaisFrequentado = this.getPeriod(response); },
        error => { console.log(error); }
      );
  }
  getPeriodoMenorFluxoElevadorMenosFrequentado() {
    this.http.get('http://localhost:5000/api/Elevator/PeriodoMenorFluxoElevadorMenosFrequentado').subscribe
      (
        response => { this.periodoMenorFluxoElevadorMenosFrequentado = this.getPeriod(response); },
        error => { console.log(error); }
      );
  }

  getPeriodoMaiorUtilizacaoConjuntoElevadores() {
    this.http.get('http://localhost:5000/api/Elevator/PeriodoMaiorUtilizacaoConjuntoElevadores').subscribe
      (
        response => { this.periodoMaiorUtilizacaoConjuntoElevadores = this.getPeriod(response); },
        error => { console.log(error); }
      );
  }

  getPercentualA() {
    this.http.get('http://localhost:5000/api/Elevator/percentualDeUsoElevadorA').subscribe
      (
        response => { this.percentualA = response; },
        error => { console.log(error); }
      );
  }

  getPercentualB() {
    this.http.get('http://localhost:5000/api/Elevator/percentualDeUsoElevadorB').subscribe
      (
        response => { this.percentualB = response; },
        error => { console.log(error); }
      );
  }

  getPercentualC() {
    this.http.get('http://localhost:5000/api/Elevator/percentualDeUsoElevadorC').subscribe
      (
        response => { this.percentualC = response; },
        error => { console.log(error); }
      );
  }

  getPercentualD() {
    this.http.get('http://localhost:5000/api/Elevator/percentualDeUsoElevadorD').subscribe
      (
        response => { this.percentualD = response; },
        error => { console.log(error); }
      );
  }

  getPercentualE() {
    this.http.get('http://localhost:5000/api/Elevator/percentualDeUsoElevadorE').subscribe
      (
        response => { this.percentualE = response; },
        error => { console.log(error); }
      );
  }

  getPeriod(period) {
    if (period.includes('M')) { return ['Matutino'] }
    else if (period.includes("V")) { return ['Vespertino'] }
    else if (period.includes("N")) { return ['Noturno'] }
  }
}
