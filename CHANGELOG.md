# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.7 *(2026-03-05)*
This version of the Unity Ads Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.17.+`
  * iOS: `ChartboostMediationAdapterUnityAds: ~> 5.4.17.0`

### Version 5.0.6 *(2026-03-05)*
This version of the Unity Ads Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.16.+`
  * iOS: `ChartboostMediationAdapterUnityAds: ~> 5.4.17.0`

### Version 5.0.5 *(2025-07-24)*
This version of the Unity Ads Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.16.+`
  * iOS: `ChartboostMediationAdapterUnityAds: ~> 5.4.16.0`

### Version 5.0.4 *(2025-07-23)*
This version of the Unity Ads Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.16.+`
  * iOS: `ChartboostMediationAdapterUnityAds: ~> 5.4.15.0`

### Version 5.0.3 *(2025-07-02)*
This version of the Unity Ads Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.15.+`
  * iOS: `ChartboostMediationAdapterUnityAds: ~> 5.4.15.0`

### Version 5.0.2 *(2025-06-02)*
This version of the Unity Ads Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.12.+`
  * iOS: `ChartboostMediationAdapterUnityAds: ~> 5.4.15.0`

### Version 5.0.1 *(2025-06-02)*
This version of the Unity Ads Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-unity-ads:5.4.12.+`
  * iOS: `ChartboostMediationAdapterUnityAds: ~> 5.4.14.0`

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
