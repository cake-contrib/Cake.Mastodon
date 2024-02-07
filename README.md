# Cake.Mastodon

A Cake AddIn that extends Cake with ability to post messages to [Mastodon](https://joinmastodon.org/) using Mastodon REST API.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.Mastodon.svg)](https://www.nuget.org/packages/Cake.Mastodon)

|Branch|Status|
|------|------|
|Master|[![Build status](https://ci.appveyor.com/api/projects/status/github/cake-contrib/Cake.Mastodon?branch=master&svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-mastodon)|
|Develop|[![Build status](https://ci.appveyor.com/api/projects/status/github/cake-contrib/Cake.Mastodon?branch=develop&svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-mastodon)|

## Important

1.2.0 
* References Cake 4.0.0
* Drops support for .NET Framework
* Supports .net 6+

## Including addin
Including addin in cake script is easy.
```
#addin "Cake.Mastodon"
```
## Usage

To use the addin just add it to Cake call the aliases and configure any settings you want.

```csharp
#addin "Cake.Mastodon"
...
string accessToken = EnvironmentVariable("MASTODON_ACCESS_TOKEN");
// How to update the status (send a toot)
var result = MastodonSendToot("https://botsin.space", accessToken, "Merely testing three", "I1");
Information($"Success: {result.IsSuccess} Code: {result.StatusCode} Phrase: {result.ReasonPhrase} Body: {result.Body}");
```

## Credits

Brought to you by [Miha Markic](https://github.com/MihaMarkic) and contributors. 

![Mastodon Follow](https://img.shields.io/mastodon/follow/001030236)