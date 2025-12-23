#r "src/Cake.Mastodon/bin/Release/net9.0/Cake.Mastodon.dll"

var result = MastodonSendToot(
            hostName: EnvironmentVariable("MASTODON_HOST"),
            accessToken: EnvironmentVariable("MASTODON_TOKEN"),
            text: "Testing 1, 2, 3",
            idempotencyKey: Guid.NewGuid().ToString());

if (result.IsSuccess)
{
    Information("Mastodon message successfully sent");
}
else
{
    Error("Failed to send Mastodon message: {0}", result.ReasonPhrase);
}