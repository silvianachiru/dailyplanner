# DailyPlanner – Expense Tracking App

Aplicație desktop full-stack dezvoltată în **C#** și **Windows Forms**, concepută pentru gestionarea și urmărirea eficientă a cheltuielilor zilnice și a bugetului personal.

---

## Tehnologii utilizate
* **Limbaj:** C# (.NET Framework / Windows Forms)
* **Mediu de dezvoltare:** Visual Studio
* **Bază de date:** Microsoft Access (`DataSet`, `TableAdapter`)
* **Interfață UI:** `DataGridView`, `PictureBox`, `MenuStrip`, `DateTimePicker`

---

## Caracteristici principale
* **Autentificare securizată:** Sistem de login bazat pe un tabel de utilizatori și validarea credențialelor.
* **Management complet (CRUD):** 
  * Gestionarea categoriilor de cheltuieli.
  * Adăugarea, editarea și asocierea produselor cu imagini reprezentative.
  * Înregistrarea cheltuielilor compuse (relație *Many-to-Many* între cheltuieli și produse prin tabelul de legătură `CheltuieliContinut`).
* **Calcul automat:** Actualizarea automată a totalului cheltuielilor în funcție de cantități și prețuri.
* **Validări și integritate:** Asigurarea integrității referențiale, validarea câmpurilor obligatorii și mesaje de confirmare pentru acțiuni critice (ștergere/salvare).
---

## Structura bazei de date
Aplicația folosește o bază de date relațională compusă din 5 entități principale:
1. **Utilizatori** (Autentificare)
2. **Categorii** (Clasificarea produselor)
3. **Produse** (Articole cu preț, unitate de măsură și imagine)
4. **Cheltuieli** (Evidența pe date și totaluri)
5. **CheltuieliContinut** (Tabel de legătură *Many-to-Many*)

---

## Prezentare interfață
* **Autentificare & Meniu Principal:** Navigare fluidă bazată pe ferestre modulare.
* **Formulare CRUD:** Interfețe intuitive pentru operarea rapidă asupra datelor.

