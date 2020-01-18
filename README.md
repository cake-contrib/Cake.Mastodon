# Cake.Mastodon

A Cake AddIn that extends Cake with ability to post messages to [Mastodon](https://joinmastodon.org/) using Mastodon REST API.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.Mastodon.svg)](https://www.nuget.org/packages/Cake.Mastodon)
[![Build status](https://ci.appveyor.com/api/projects/status/vi07dth3d1gek7ak?svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-mastodon)

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

Brought to you by [Miha Markic](https://github.com/MihaMarkic) ([@MihaMarkic](https://twitter.com/MihaMarkic/)) and contributors. 