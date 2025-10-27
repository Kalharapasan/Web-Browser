# Web Browser Pro

**Web Browser Pro** is a custom Windows desktop browser built using **Visual Basic .NET (VB.NET)**.  
It offers a sleek, modern interface with features like bookmarks, tabbed browsing, and sidebar navigation, all powered by **Bunifu** and **DevExpress** UI frameworks.

---

## 🌐 Features

- **Tabbed Browsing:** Open and manage multiple websites simultaneously  
- **Bookmarks Manager:** Save, edit, and organize your favorite sites  
- **Sidebar Navigation:** Quick access to tools and bookmarks  
- **Modern UI Design:** Built with Bunifu and DevExpress components for a professional look  
- **Integrated PDF Viewing:** Powered by DevExpress PDF Core  
- **Search and Address Bar:** Responsive input box with auto-focus and search detection  

---

## 🧰 Technologies Used

- **Language:** Visual Basic .NET (VB.NET)  
- **Framework:** .NET Framework 4.x  
- **UI Libraries:**  
  - [Bunifu UI v1.5.3](https://bunifuframework.com/)  
  - [DevExpress WinForms v18.2](https://www.devexpress.com/)  
- **IDE:** Visual Studio 2019 or later  
- **Dependencies:**  
  - `Bunifu.Core.dll`  
  - `Bunifu_UI_v1.5.3.dll`  
  - `DevExpress.*.v18.2.dll`  
  - `SQLABC_ModernUI.dll`

---

## 🗂️ Project Structure

```
Web Browser Pro/
├── Web Browser Pro.sln                     # Visual Studio solution file
├── Web Browser Pro/
│   ├── App.config
│   ├── Web Browser Pro.vbproj              # VB.NET project file
│   ├── Form1.vb                            # Main browser form
│   ├── Bookmarks.vb                        # Bookmark management UI
│   ├── Sidebar.vb                          # Sidebar and navigation logic
│   ├── My Project/                         # Auto-generated VS files
│   └── bin/Debug/                          # Compiled binaries and resources
│       ├── Web Browser Pro.exe
│       ├── Bunifu.Core.dll
│       ├── Bunifu_UI_v1.5.3.dll
│       ├── DevExpress.*.dll
│       ├── SQLABC_ModernUI.dll
│       └── *.config / *.xml / *.pdb
└── .vs/                                    # Visual Studio cache and user data
```

---

## ▶️ How to Run

1. Open the solution file (`Web Browser Pro.sln`) in **Visual Studio 2019** or newer.  
2. Ensure all dependencies (Bunifu and DevExpress DLLs) are correctly referenced.  
3. Build the project (`Ctrl + Shift + B`).  
4. Run the solution (`Ctrl + F5`).  
5. The main window (`Form1.vb`) will launch, showing the browser interface.

---

## 🧩 Main Components

| Form Name | Function |
|------------|-----------|
| `Form1.vb` | Main browser interface, address/search bar |
| `Bookmarks.vb` | Manage saved bookmarks |
| `Sidebar.vb` | Quick access panel for navigation and tools |

---

## 💡 Developer Notes

- DevExpress 18.2 libraries must be properly licensed or installed to run the project.  
- Bunifu controls (UI framework) are required for the interface to render correctly.  
- For best performance, run in **x86 mode** under the .NET Framework 4.x.  
- You can modify the default home page and search provider inside `Form1.vb`.

---

## 📄 License

This project is provided for educational and demonstration purposes.  
You may modify and distribute it freely with attribution.

---

**Author:** Unknown (2019 release)  
**Updated README:** 2025 by ChatGPT
