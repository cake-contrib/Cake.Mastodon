using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.Mastodon
{
    /// <summary>
    /// <para>Contains functionality related to <see href="https://docs.joinmastodon.org/client/intro/">Mastodon REST API</see>.</para>
    /// <para>
    /// In order to use the commands for this addin, include the following in your build.cake file to download and
    /// reference from NuGet.org:
    /// <code>
    /// #addin Cake.Mastodon
    /// </code>
    /// </para>
    /// </summary>
    [CakeAliasCategory("Mastodon")]
    public static class MastodonAliases
    {
        /// <summary>
        /// Send a Toot using the "Mastodon" REST API.
        /// </summary>
        /// <param name="context">The Cake Context.</param>
        /// <param name="text">Text content of the status. </param>
        /// <param name="accessToken">You app's access token - don't share this.</param>
        /// <param name="hostName">Hostname where you Mastodon account lives, i.e. https://botsin.space.</param>
        /// <param name="idempotencyKey">
        /// Prevent duplicate submissions of the same status. 
        /// Idempotency keys are stored for up to 1 hour, and can be any arbitrary string. Consider using a hash or UUID generated client-side.
        /// </param>
        /// <param name="visibility">Visibility of the posted status.</param>
        /// <example>
        /// <code>
        ///     string accessToken = EnvironmentVariable("MASTODON_ACCESS_TOKEN")
        /// 
        ///     var result = MastodonSendToot("https://botsin.space", accessToken, "Merely testing three", "I1");
        ///     Information($"Success: {result.IsSuccess} Code: {result.StatusCode} Phrase: {result.ReasonPhrase} Body: {result.Body}");
        /// </code>
        /// </example>
        [CakeMethodAlias]
        [CakeNamespaceImport("Cake.Mastodon")]
        public static TootResponse MastodonSendToot(this ICakeContext context, string hostName, string accessToken, string text, string? idempotencyKey = null, 
            TootVisibility visibility = TootVisibility.Public)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var mastodonProvider = new MastodonProvider(hostName, accessToken);
            return mastodonProvider.Toot(text, idempotencyKey, visibility, ct: default).GetAwaiter().GetResult();
        }
    }
}
