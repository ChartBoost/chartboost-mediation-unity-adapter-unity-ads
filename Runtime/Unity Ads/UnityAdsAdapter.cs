using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.UnityAds.Common;
using Chartboost.Mediation.UnityAds.Default;

namespace Chartboost.Mediation.UnityAds
{
    /// <inheritdoc cref="IUnityAdsAdapter"/>
    public sealed class UnityAdsAdapter 
    {
        internal static IUnityAdsAdapter Instance = new UnityAdsDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.0";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IUnityAdsAdapter.TestMode"/>
        public static bool TestMode
        {
            get => Instance.TestMode;
            set => Instance.TestMode = value;
        }

        /// <inheritdoc cref="IUnityAdsAdapter.SetGDPRConsentOverride"/>
        public static void SetGDPRConsentOverride(bool gdprStatus) 
            => Instance.SetGDPRConsentOverride(gdprStatus);

        /// <inheritdoc cref="IUnityAdsAdapter.SetPrivacyConsentOverride"/>
        public static void SetPrivacyConsentOverride(bool consentStatus)
            => Instance.SetPrivacyConsentOverride(consentStatus);
    }
}
