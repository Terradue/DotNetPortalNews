/*!

\namespace Terradue.News
@{
    Terradue.News Software Package

    \xrefitem sw_version "Versions" "Software Package Version" 1.0.11

    \xrefitem sw_link "Link" "Software Package Link" [Terradue.New](https://git.terradue.com/sugar/terradue-news)

    \xrefitem sw_license "License" "Software License" [incubating](https://git.terradue.com/sugar/terradue-news)

    \xrefitem sw_req "Require" "Software Dependencies" \ref Terradue.OpenSearch

    \xrefitem sw_req "Require" "Software Dependencies" \ref Terradue.OpenSearch.Tumblr

    \xrefitem sw_req "Require" "Software Dependencies" \ref Terradue.OpenSearch.Twitter

    \xrefitem sw_req "Require" "Software Dependencies" \ref Terradue.ServiceModel.Ogc.OwsContext

    \xrefitem sw_req "Require" "Software Dependencies" \ref Terradue.Portal

    \ingroup Community
@}

*/

using System.Reflection;
using System.Runtime.CompilerServices;
using NuGet4Mono.Extensions;

[assembly: AssemblyTitle("Terradue.News")]
[assembly: AssemblyDescription("Terradue.News is a library targeting .NET 4.0 and above that provides opensearch interfaces for News entities of Terradue Portal")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Terradue")]
[assembly: AssemblyProduct("Terradue.News")]
[assembly: AssemblyCopyright("Terradue")]
[assembly: AssemblyAuthors("Enguerran Boissier")]
[assembly: AssemblyProjectUrl("https://git.terradue.com/sugar/terradue-news")]
[assembly: AssemblyLicenseUrl("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("1.0.11")]
[assembly: AssemblyInformationalVersion("1.0.11")]

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]