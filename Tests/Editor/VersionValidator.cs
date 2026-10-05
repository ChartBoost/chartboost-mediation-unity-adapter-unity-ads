using Chartboost.Editor;
using Chartboost.Mediation.UnityAds;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.unity-ads";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.UnityAds";
        
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, UnityAdsAdapter.AdapterUnityVersion);
    }
}
