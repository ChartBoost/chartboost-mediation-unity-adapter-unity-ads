using Chartboost.Constants;
using Chartboost.Mediation.UnityAds.Common;
using UnityEngine;

namespace Chartboost.Mediation.UnityAds.Android
{
    internal partial class UnityAdsAdapter : IUnityAdsAdapter
    {
        private const string UnityAdsAdapterConfiguration = "com.chartboost.mediation.unityadsadapter.UnityAdsAdapterConfiguration";
        private const string FunctionGetDebugMode = "getDebugMode";
        private const string FunctionSetDebugMode = "setDebugMode";
        private const string FunctionSetGdprConsentOverride = "setGdprConsentOverride";
        private const string FunctionSetPrivacyConsentOverride = "setPrivacyConsentOverride";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            UnityAds.UnityAdsAdapter.Instance = new UnityAdsAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }
        
        /// <inheritdoc/>
        public bool TestMode
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionGetDebugMode);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetDebugMode, value);
            }
        }

        /// <inheritdoc/>
        public void SetGDPRConsentOverride(bool gdprStatus)
        {

            using var currentActivity = SharedAndroidConstants.UnityPlayerCurrentActivity();
            using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetGdprConsentOverride, currentActivity, gdprStatus);
        }

        /// <inheritdoc/>
        public void SetPrivacyConsentOverride(bool consentStatus)
        {
            using var currentActivity = SharedAndroidConstants.UnityPlayerCurrentActivity();
            using var adapterConfiguration = new AndroidJavaObject(UnityAdsAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetPrivacyConsentOverride, currentActivity, consentStatus);
        }
    }
}
