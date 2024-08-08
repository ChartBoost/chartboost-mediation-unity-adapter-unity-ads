using System.Runtime.CompilerServices;
using Chartboost.Mediation.UnityAds;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.UnityAdsAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.UnityAdsAssemblyInfoIOS)]

namespace Chartboost.Mediation.UnityAds
{
    internal class AssemblyInfo
    {
        public const string UnityAdsAssemblyInfoAndroid = "Chartboost.Mediation.UnityAds.Android";
        public const string UnityAdsAssemblyInfoIOS = "Chartboost.Mediation.UnityAds.IOS";
    }
}
