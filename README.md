
# PiotrTrojan.AspNetCore.IdentityErrorLocalization

## Usage

To add localization to your Identity use `Add{X}IdentityErrorDescriber()` method to your IdentityBuilder chain, where {X} is your desired language.
Languages currently available:

* German (de-DE)
* Spanish (es-ES)
* Persian (fa-IR)
* Portuguese (pt-PT)
* French (fr-FR)
* Polish (pl-PL)
* Portuguese (pt-PT)
* Russian (ru-RU)
* Turkish (tr-TR)

Example:

```cs
serviceCollection
  .AddIdentity<IdentityUser<Guid>, IdentityRole<Guid>>()
  .AddEntityFrameworkStores<DbContext>()
  .AddPolishIdentityErrorDescriber() // Polish errors translations added
  .AddDefaultTokenProviders();
```
Every available language is in separate package, `PiotrTrojan.AspNetCore.IdentityErrorLocalization.{Culture}`, e.g. `PiotrTrojan.AspNetCore.IdentityErrorLocalization.de-DE`

Feel free to suggest me improvements or to help me with new languages.

This is my first open source project ;)

[piotrtrojan.com](https://piotrtrojan.com)
