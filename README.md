# Tworzenie testowalnych aplikacji
## Laboratorium #8 - Testy integracyjne część 1

### Prowadzący zajęcia
Bartosz Sokół, Nikodem Rafalski

### Opis zajęć
Na ósmych zajęciach kontynuujemy pracę nad wspólnym projektem, który będziemy rozwijać do końca semestru.
Zobaczymy jak testować większą część systemu za pomocą testów integracyjnych.
Skupimy się na testowaniu powiązania aplikacji z bazą danych i sprawdzaniu integralności systemu.

### Materiały
* Wymagania które ma spełniać nasza aplikacja: [Wymagania](Wymagania.md)
* Funkcje do zaimplementowania: [Zadania](Zadania.md)
* Zadanie domowe i informacje o projektach: [Zadanie domowe i projekt](ZadanieDomowe.md)
* Kod: [UamTTA](kod/UamTTA)

### Pomocne zasoby
Do kontaktu z bazą danych będziemy używać Entity Framework w wersji 6.x. Materiały o EF:
* [Wprowadzenie do EF6 Code First](https://msdn.microsoft.com/en-us/data/jj193542.aspx?f=255&MSPPError=-2147217396)
* [Materiały video na Channel9](https://channel9.msdn.com/Search?term=entity%20framework#ch9Search&lang-en=en)
* [Strona główna EF6](http://entityframework.codeplex.com/)

Nasze API będzie wystawione poprzez ASP.NET MVC 5 / WebAPI 2 i będzie zgodne z protokołem REST. Materiały:
* [Protokół REST](https://en.wikipedia.org/wiki/Representational_state_transfer)
* [Narzędzie do testowania wywołań REST z Chrome - Postman](https://chrome.google.com/webstore/detail/postman/fhbjgbiflinjbdggehcddcbncdddomop)
* [Tutorial ASP.NET Web API 2](http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api)

Kod powstały na zajęciach będzie budowany przez build server TeamCity:
* [Informacje o TeamCity](https://www.jetbrains.com/teamcity/)
* [Nasz serwer TeamCity](http://tta2015z.vm.wmi.amu.edu.pl:8111/)
