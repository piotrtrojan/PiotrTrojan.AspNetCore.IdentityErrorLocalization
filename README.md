
# PiotrTrojan.AspNetCore.IdentityErrorLocalization

## Release notes

### 1.0.3

* Fixed bug in Multilang - English Error Describer (included in Microsoft.Extensions.Identity.Core) is used for 'en' or no language provided.
* Information (Exception message) added when IdentityErrorDescriberFactory is not registered (Multilang).
  It will inform user that he forgot to register factory (via extension method) instead of throwing generic Exception (Cannot resolve service).
* Fixed nuget files generation (internal change)

## Usage

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
* Portuguese (pt-PT)
* French (fr-FR)
* Polish (pl-PL)
* Portuguese (pt-PT)
* Russian (ru-RU)
* Turkish (tr-TR)

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
