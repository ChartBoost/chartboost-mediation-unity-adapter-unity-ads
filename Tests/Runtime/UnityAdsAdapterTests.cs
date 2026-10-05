using Chartboost.Mediation.UnityAds;
using Chartboost.Tests.Runtime;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Chartboost.Tests
{
    internal class UnityAdsAdapterTests : DebugLogLevelFixture
    {
        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => UnityAdsAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => UnityAdsAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => UnityAdsAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => UnityAdsAdapter.PartnerDisplayName);
        
        [Test]
        public void TestMode()
            => TestUtilities.TestBooleanAccessor(() => UnityAdsAdapter.TestMode, value => UnityAdsAdapter.TestMode = value);

        // The Editor uses UnityAdsDefault, which only logs; HB-12134 logged the wrong method name.
        [TestCase(true), TestCase(false)]
        public void SetGDPRConsentOverrideLogsItsName(bool value)
        {
            if (!Application.isEditor) Assert.Ignore("The Default implementation only runs in the Editor.");
            LogAssert.Expect(LogType.Log, "SetGDPRConsentOverride does nothing on UnityAdsDefault");
            UnityAdsAdapter.SetGDPRConsentOverride(value);
        }

        [TestCase(true), TestCase(false)]
        public void SetPrivacyConsentOverrideLogsItsName(bool value)
        {
            if (!Application.isEditor) Assert.Ignore("The Default implementation only runs in the Editor.");
            LogAssert.Expect(LogType.Log, "SetPrivacyConsentOverride does nothing on UnityAdsDefault");
            UnityAdsAdapter.SetPrivacyConsentOverride(value);
        }
    }
}
