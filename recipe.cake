#load nuget:https://pkgs.dev.azure.com/cake-contrib/Home/_packaging/addins/nuget/v3/index.json?package=Cake.Recipe&version=4.1.0-alpha0036

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "Cake.Mastodon",
    repositoryOwner: "cake-contrib",
    repositoryName: "Cake.Mastodon",
    appVeyorAccountName: "cakecontrib",
    shouldRunInspectCode: false,
	shouldRunCodecov: false,
    shouldRunDotNetPack: true,
    shouldRunCoveralls: false); // Disabled because it's currently failing

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    testCoverageFilter: "+[*]* -[nunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");
Build.RunDotNet();
