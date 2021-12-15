# PiotrTrojan.AspNetCore.IdentityErrorLocalization

## Release notes

### 1.0.7

* Portuguese translation minor fixes.
* Polish translation minor fixes.

### 1.0.6

* Fix for dependency injection in Multilanguage package.
* Unit tests added (to be continued).

### 1.0.4

* Swedish (sv-SE) translations added.
* Ukrainian (uk-UA) translations added.
* C# 9 syntax applied to shorted code.

### 1.0.3

* Fixed bug in Multilang - English Error Describer (default IdentityErrorDescriber included in Microsoft.Extensions.Identity.Core) is used for 'en' or no language provided.
* Information (Exception message) added when IdentityErrorDescriberFactory is not registered (Multilang).
  It will inform user that he forgot to register factory (via extension method) instead of throwing generic Exception (Cannot resolve service).
* Fixed nuget files generation (internal change)

## Usage

### Nuget packages

#### Multi language support

* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.Multilang](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.Multilang)

#### Specific language

* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.de-DE](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.de-DE)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.es-ES](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.es-ES)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.fa-IR](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.fa-IR)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.fr-FR](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.fr-FR)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.pl-PL](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.pl-PL)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt-PT](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt-PT)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.sv-SE](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.sv-SE)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.ru-RU](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.ru-RU)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.tr-TR](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.tr-TR)
* [nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.uk-UA](https://www.nuget.org/packages/PiotrTrojan.AspNetCore.IdentityErrorLocalization.uk-UA)

### Multilanguage

Error messages can be generated based on `accept-language` HTTP header.
For this, install `PiotrTrojan.AspNetCore.IdentityErrorLocalization.Multilang` package, register proper factory:

```cs
serviceCollection.RegisterIdentityErrorDescriberFactory();
```

and proper error describer

```cs
serviceCollection
  .AddIdentity<IdentityUser<Guid>, IdentityRole<Guid>>() // Returns IdentityBuilder, Generics just as an example.
  .AddMultilangIdentityErrorDescriber(); // Multilanguage support added.
```

### Specific language

To add localization to your Identity use `Add{X}IdentityErrorDescriber()` method to your IdentityBuilder chain, where {X} is your desired language.
Languages currently available:

* German (de-DE)
* Spanish (es-ES)
* Persian (fa-IR)
* French (fr-FR)
* Polish (pl-PL)
* Portuguese (pt-PT)
* Swedish (sv-SE)
* Russian (ru-RU)
* Turkish (tr-TR)
* Ukrainian (uk-UA)

Example:

```cs
serviceCollection
  .AddIdentity<IdentityUser<Guid>, IdentityRole<Guid>>() // Returns IdentityBuilder
  .AddPolishIdentityErrorDescriber(); // Polish errors translations added
```

Every available language is in separate package, `PiotrTrojan.AspNetCore.IdentityErrorLocalization.{Culture}`, e.g. `PiotrTrojan.AspNetCore.IdentityErrorLocalization.de-DE`

Feel free to suggest me improvements or to help me with new languages.

This is my first open source project ;)

[piotrtrojan.com](https://piotrtrojan.com)
