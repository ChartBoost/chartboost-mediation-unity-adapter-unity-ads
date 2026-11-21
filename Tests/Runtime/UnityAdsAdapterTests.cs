using Chartboost.Mediation.UnityAds;
using Chartboost.Testing;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class UnityAdsAdapterTests
    {
        private const string Default = "UnityAdsDefault";

        [Test]
        public void Identity() => AdapterContract.AssertIdentity("unity", "UnityAds", UnityAdsAdapter.AdapterUnityVersion,
            UnityAdsAdapter.PartnerIdentifier, UnityAdsAdapter.PartnerDisplayName, UnityAdsAdapter.AdapterNativeVersion, UnityAdsAdapter.PartnerSDKVersion);

        [Test]
        public void TestModeKeepsItsValue()
            => AdapterContract.AssertKeeps(() => UnityAdsAdapter.TestMode, value => UnityAdsAdapter.TestMode = value, true, false);

        [TestCase(true), TestCase(false)]
        public void SetGDPRConsentOverrideLogsOnTheDefault(bool value)
            => AdapterContract.AssertDefaultSetterLogs(nameof(UnityAdsAdapter.SetGDPRConsentOverride), Default, () => UnityAdsAdapter.SetGDPRConsentOverride(value));

        [TestCase(true), TestCase(false)]
        public void SetPrivacyConsentOverrideLogsOnTheDefault(bool value)
            => AdapterContract.AssertDefaultSetterLogs(nameof(UnityAdsAdapter.SetPrivacyConsentOverride), Default, () => UnityAdsAdapter.SetPrivacyConsentOverride(value));
    }
}
