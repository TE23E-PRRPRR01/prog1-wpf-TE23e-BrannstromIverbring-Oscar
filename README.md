# C# i Visual Studio Code
VS Code är en snabbt och lättanvänt IDE som du kan skapa ditt C#-projekt med.

## Förberedelser

### Installera och ställ in VS Code

* Installera [Dotnet 9](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-9.0.101-windows-x64-installer)

### Installera följande tillägg i VS Code

* [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) – Ger VS Code stöd för C#
* [C# Toolbox of Productivity](https://marketplace.visualstudio.com/items?itemName=RichardZampieriprog.csharp-snippet-productivity) – Lägger till en del extra användbara genvägar och funktioner, tex för att skapa nya projekt och klasser
* [Open Folder Context Menu](https://marketplace.visualstudio.com/items?itemName=chrisdias.vscode-opennewinstance) - För att enkelt öppna en mapp
* [gitignore](https://marketplace.visualstudio.com/items?itemName=codezombiech.gitignore) – Underlättar arbetet med git och VS Code. Om du söker efter den, se till att ta den av CodeZombie!
* [VSCode Great Icons](https://marketplace.visualstudio.com/items?itemName=emmanuelbeziat.vscode-great-icons) – Gör det lättare att känna igen filtyper
* [RedHat XML](https://marketplace.visualstudio.com/items?itemName=redhat.vscode-xml) - För att jobba med WPF och Xaml
* [C# XML Documentation Comments](https://marketplace.visualstudio.com/items?itemName=k--kato.docomment) - För att kommentera metoder och klasser

### VS Code inställningar

* Gå in Inställningar och klistra in följande:

```JSON
    ,
    "files.associations": {
        "*.xaml": "xml"
    },
    "xml.fileAssociations": [
        {
            "pattern": "**/*.xaml",
            "systemId": "https://raw.githubusercontent.com/karye/xamelot/refs/heads/master/syntax/xaml.xsd"
        }
    ],
```

## Skapa C#-projekt

1. Skapa en ny mapp
2. Öppna den tomma mappen i **VS Code**
3. Öppna en ny terminal (ctrl + ö)
4. Skapa grundkoden med:

```bash
dotnet new wpf
```
4. Koda och testa med:

```bash
dotnet run
```

## Ladda upp till GitHub

1. Tryck på ikonen för Source Control
2. Fyll i en commit meddelande som beskriver vad du har gjort
3. Tryck på **Commit & Sync**
