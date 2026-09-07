# File to PDF Converter

A lightweight, offline Windows desktop app that converts common document formats (Word, PowerPoint, Excel, OpenDocument, and plain text) to PDF — no internet connection required, no data leaves your machine.

## Features
- Convert `.docx`, `.doc`, `.pptx`, `.ppt`, `.xlsx`, `.xls`, `.odt`, `.ods`, `.odp`, `.rtf`, `.txt` to PDF
- Drag-and-drop or file picker
- Choose a custom output folder (defaults to same folder as original file)
- Fully offline — powered by a bundled portable LibreOffice engine
- Clean, simple interface

## Why offline?
Online PDF converters require uploading personal or sensitive documents to third-party servers. This tool runs entirely on your machine — nothing is uploaded anywhere.

## Screenshots
*(add 1-2 screenshots here of the app in use)*

## Installation
1. Download the latest installer from [Releases](link-to-your-releases-page)
2. Run `FileConverterApp_Setup.exe`
3. Launch "File to PDF Converter" from your Start Menu

## Building from source
This project depends on two components that aren't included in this repository due to size (LibreOffice Portable and Microsoft's Aptos font files):

1. Clone this repo
2. Download [LibreOffice Portable](https://portableapps.com/apps/office/libreoffice_portable) and extract it into `FileConverterApp/libre/`
3. Download [Microsoft Aptos Fonts](https://www.microsoft.com/en-us/download/details.aspx?id=106087) and place the `.ttf` files into `FileConverterApp/Fonts/`
4. Open `ConverterTest.sln` in Visual Studio 2022+
5. Build in Release mode
6. (Optional) Use the included `Installer.iss` with [Inno Setup](https://jrsoftware.org/isinfo.php) to build your own installer

## Known limitations
- Some modern Word documents using theme-linked fonts may render bold headings slightly differently than in Word (cosmetic only)
- One file converted at a time (no batch/multi-file queue yet)
- PDF → editable format conversion (reverse direction) not yet supported

## Tech stack
- C# / WinForms (.NET 8)
- LibreOffice (headless, portable) as the conversion engine

## License
*(add a license, e.g., MIT, if you want others to freely use/modify this)*