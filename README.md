# AI Bug Report Generator

Applikationen är utvecklad med .NET och Blazor och använder språkmodellen Llama 3.2 lokalt via Ollama för att omvandla vanliga felbeskrivningar till strukturerade buggrapporter.

## Krav

För att köra projektet behövs:

- Visual Studio med stöd för ASP.NET och Blazor, alternativt .NET SDK
- Ollama
- AI-modellen Llama 3.2

## Så startar du applikationen

1. Ladda ner projektet från GitHub via **Code → Download ZIP**.

2. Packa upp ZIP-filen.

3. Installera och starta Ollama.

4. Öppna en terminal och kör följande kommando för att hämta AI-modellen:

   `ollama pull llama3.2`

5. Öppna filen `AiBugReport.csproj` i Visual Studio.

6. Starta applikationen med **F5**.

## Testa funktionen

1. Öppna applikationen i webbläsaren.
2. Skriv en felbeskrivning, exempelvis: *"När jag klickar på spara-knappen händer ingenting."*
3. Klicka på knappen för att generera en buggrapport.
4. Applikationen skickar beskrivningen till den lokala AI-modellen och visar en strukturerad buggrapport.

**Observera:** Ollama måste vara igång på datorn för att AI-genereringen ska fungera.
