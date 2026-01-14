<div align="center">

# 🖤 quickdelight (order form)

a **vb winforms** coursework project that simulates a small food order system.  
adds items to a table, calculates totals, applies **gst (15%)**, and keeps the UI feeling “real app-ish”.

![.NET](https://img.shields.io/badge/.NET-10.0-ff78c8?style=for-the-badge)
![VB](https://img.shields.io/badge/Visual%20Basic-.NET-ff4db8?style=for-the-badge)
![Windows](https://img.shields.io/badge/Platform-Windows-0b0b0b?style=for-the-badge)

</div>

---

## what is this?

**quickdelight** is a simple **windows forms order form app** built in **visual basic (.net)**.

it was made as part of my course work (from last year), and i’m keeping it here as a record of:
- building a working desktop UI
- handling user input safely (validation)
- calculating prices + tax
- iterating through versions like a tiny “release pipeline” 

---

##  features

- **live clock** updates every second
- **meal selector** (combo box)
  - includes: `Pizza`, `Burger`, `Salad`, `Sushi`
- **add order line** into a grid (meal + qty + price + subtotal)
- **delete selected rows**
- auto-calculates:
  - **total**
  - **gst (15%)**
  - **to pay**
- basic validation so the app doesn’t explode if you leave stuff blank 😭

---

##  built with

- **Visual Studio**
- **Visual Basic .NET**
- **.NET 10 (Windows target)**
- **Windows Forms**

---

##  project layout

this repo includes multiple stages/versions saved in folders (like a mini dev pipeline):

- `01-AutomatedBuild/` → **v1.1**
- `02-Automated Test/` → **v1.2**
- `05-Production/` → **v1.3**
- `QuickDelightOrderForm/` → main project folder

each version is basically the same app, kept as checkpoints across the course steps.

---

##  how to run

### option A: visual studio (recommended)
1. download / clone this repo
2. open the solution file (example):
   - `QuickDelight/QuickDelightOrderForm/QuickDelightOrderForm.slnx`
3. press **Start** (▶)

### option B: command line
> requires the .NET SDK installed

```bash
dotnet build
dotnet run --project "QuickDelight/QuickDelightOrderForm/QuickDelightOrderForm/QuickDelightOrderForm.vbproj"
