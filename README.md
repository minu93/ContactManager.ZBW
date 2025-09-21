# ContactManager.ZBW

> Ein schlanker **Kontakt- und Mitarbeiter-Manager** für Windows mit **C#/.NET (WinForms)**, **SQLite** und **Entity Framework**.  
> Fokus: **einfache Erfassung**, **schnelles Suchen**, **Historien & Notizen**, **lokale Persistenz**.

---

## Gruppe
**Gramoz Eqimaj, Manuel Zwiker, Amin Fas**

---

## Tech-Stack
- **C# / .NET**
- **WinForms**
- **SQLite** (lokal)
- **Entity Framework** (EF Core)

---

## Features

- **Authentifizierung**  
  Einfache Anmeldung zum Schutz der lokalen Daten.
  Login:
  `Username: admin, Password: admin123` 

- **CRUD für Mitarbeiter & Kunden**  
  - **Erfassung**, **Mutation**, **De-/Aktivierung**, **Löschen**
  - **Automatische Vergabe von Mitarbeiternummern**
  - **Mutationshistorie** von Kontaktdaten
    → Per **Rechtsklick** auf Kunde/Mitarbeiter Historien öffnen

- **Notizen & Verlauf**  
  - **Kundennotizen** mit **Historie/Protokoll**

- **Suche & Filter**  
  - Schnelle Suche über **Name, Vorname, Geburtsdatum, Telefonnummer**

- **Kunden-Dashboard**  
  - Übersicht an KPIs

- **Beispieldaten Import/Export**  
  - Zum schnellen Start & für Demos
