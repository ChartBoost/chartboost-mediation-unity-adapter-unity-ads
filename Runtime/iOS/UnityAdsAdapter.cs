using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.UnityAds.Common;
using UnityEngine;

namespace Chartboost.Mediation.UnityAds.IOS
{
    internal class UnityAdsAdapter : IUnityAdsAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            UnityAds.UnityAdsAdapter.Instance = new UnityAdsAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMUnityAdsAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMUnityAdsAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMUnityAdsAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMUnityAdsAdapterPartnerDisplayName();
        
        /// <inheritdoc/>
        public bool TestMode
        {
            get => _CBMUnityAdsAdapterGetTestMode();
            set => _CBMUnityAdsAdapterSetTestMode(value);
        }

        /// <inheritdoc/>
        public void SetGDPRConsentOverride(bool gdprStatus) 
            => _CBMUnityAdsAdapterSetGDPRConsentOverride(gdprStatus);

        /// <inheritdoc/>
        public void SetPrivacyConsentOverride(bool consentStatus) 
            => _CBMUnityAdsAdapterSetPrivacyConsentOverride(consentStatus);

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMUnityAdsAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMUnityAdsAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMUnityAdsAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMUnityAdsAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMUnityAdsAdapterGetTestMode();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMUnityAdsAdapterSetTestMode(bool testMode);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMUnityAdsAdapterSetGDPRConsentOverride(bool gdprStatus);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMUnityAdsAdapterSetPrivacyConsentOverride(bool consentStatus);
    }
}
