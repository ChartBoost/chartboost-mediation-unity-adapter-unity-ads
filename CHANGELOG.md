# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Unity Ads Adapter.

#Added
- Support for the following `Unity Ads` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.12.+`
    * iOS: `ChartboostMediationAdapterUnityAds ~> 5.4.12.0`
    
- `UnityAdsAdapter.cs` with Configuration Properties for `Unity Ads`.
- The following properties have been added in `UnityAdsAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool TestMode`

- The following methods have been added in `UnityAdsAdapter.cs`
    * `void SetGDPRConsentOverride(bool gdprStatus)`
    * `void SetPrivacyConsentOverride(bool consentStatus)`