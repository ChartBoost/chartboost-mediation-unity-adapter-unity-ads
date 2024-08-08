using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.UnityAds.Common
{
    /// <summary>
    /// The Chartboost Mediation UnityAds adapter.
    /// </summary>
    internal interface IUnityAdsAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Enable/disable Unity Ads's test mode. Remember to set this to false in production.
        /// </summary>
        public bool TestMode { get; set; }


        /// <summary>
        /// Use to manually set the consent status on the Unity Ads SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.
        /// </summary>
        public void SetGDPRConsentOverride(bool gdprStatus);

        
        /// <summary>
        /// Use to manually set the consent status on the Unity Ads SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.
        /// <br/>
        /// Based off <a href="https://docs.unity.com/ads/en-us/manual/CCPACompliance">Unity's Documentation</a>.
        /// </summary>
        public void SetPrivacyConsentOverride(bool consentStatus);
    }
}
