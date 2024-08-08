using Chartboost.Logging;
using Chartboost.Mediation.UnityAds;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class UnityAdsAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

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

        [Test, Order(0)]
        public void SetGDPRConsentTrue() 
            => UnityAdsAdapter.SetGDPRConsentOverride(true);
        
        [Test, Order(1)]
        public void SetGDPRConsentFalse() 
            => UnityAdsAdapter.SetGDPRConsentOverride(false);
        
        [Test, Order(0)]
        public void SetPrivacyConsentTrue() 
            => UnityAdsAdapter.SetPrivacyConsentOverride(true);
        
        [Test, Order(1)]
        public void SetPrivacyConsentFalse() 
            => UnityAdsAdapter.SetPrivacyConsentOverride(false);
    }
}
