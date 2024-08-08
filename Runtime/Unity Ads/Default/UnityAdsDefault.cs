using Chartboost.Logging;
using Chartboost.Mediation.UnityAds.Common;

namespace Chartboost.Mediation.UnityAds.Default
{
    internal class UnityAdsDefault : IUnityAdsAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => UnityAdsAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => UnityAdsAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "unity";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "UnityAds";

        /// <inheritdoc/>
        public bool TestMode { get; set; }

        /// <inheritdoc/>
        public void SetGDPRConsentOverride(bool gdprStatus)
            => LogController.Log($"{nameof(SetGDPRConsentOverride)} does nothing on {nameof(UnityAdsDefault)}", LogLevel.Info);

        /// <inheritdoc/>
        public void SetPrivacyConsentOverride(bool consentStatus)
            => LogController.Log($"{nameof(SetGDPRConsentOverride)} does nothing on {nameof(UnityAdsDefault)}", LogLevel.Info);
    }
}
