# Vejledningsbooking

Personer: André, Gustav, Nicklas, Kristian, Kristian, Rasmus, Lui, Morten og Nikolaj.

## Lucidchart
[Link](https://lucid.app/lucidchart/invitations/accept/inv_8253e560-569f-423d-9a85-b8ff061d28ed?viewport_loc=498%2C242%2C1707%2C779%2Ca7h_gqcetVhl)

## How to start docker databse
Run this command in a terminal (In the project directory): `docker-compose up -d --build`

## EF core
[Manage migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

* Add changes: `Add-Migration NAME` (Change NAME with the migration name)
* Update database `update-database`

## Projekt besvarelse

Vi har oprettet et clean architecture projekt, hvori der ligger forskellige lag som fremgår af modellen udleveret af læren.

Vi har herudover tilføjet `WebUI` og `Api` projektet, da vi ville udforske, hvordan sådanne projekter skulle refere til vores andre class liberies.

I opgaven har vi benyttet Entity Framework Core som har lagt grund til vores data styring. Vi har også benyttet os af docker som her bruges til at skabe en matchende database på alle udviklings maskiner, da alle databaser på denne måde oprettes med samme information.

Under udviklingen af opgaven besluttede vi at benytte [Repository og Unit of work patterns](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application) til at skabe database absraktionen. På denne måde bliver vores kode mere testvenligt og giver mulighed for at skabe mock classer af samme funktion.

Herudover har vi brugt interfaces til at gemme vores database integration væk og benytter derfor `IVejledningsBookingContext` til at refere til vores context. Dette gør det også muligt at vores context bliver testbar.

Til sidst har vi også lavet services som gemmer vores logik væk og gør det muligt en en eventuel controller kan kalde en enkelt metode.