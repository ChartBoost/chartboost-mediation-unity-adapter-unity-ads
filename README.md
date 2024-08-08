# Chartboost Mediation Unity SDK - UnityAds Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.unity-ads/Editor/UnityAdsAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.unity-ads)

In order to add the Chartboost Mediation Unity SDK - UnityAds Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.unity-ads": "5.0.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.UnityAds)

To add the Chartboost Mediation Unity SDK - UnityAds Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.UnityAds` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.UnityAds` package. Choose the appropriate version and install.

# Usage
The following code block exemplifies usage of the `UnityAdsAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {UnityAdsAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.4.12.0.0
Debug.Log($"Adapter Native Version: {UnityAdsAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 4.12.0
Debug.Log($"Partner SDK Version: {UnityAdsAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: unity
Debug.Log($"Partner Identifier: {UnityAdsAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: Unity Ads
Debug.Log($"Partner Display Name: {UnityAdsAdapter.PartnerDisplayName}");
```

## Test Mode
To enable test mode for the UnityAds adapter, the following property has been made available:

```csharp
UnityAdsAdapter.TestMode = true;
```

## Set GDPR Consent Override
Use to manually set the consent status on the Unity Ads SDK.This is generally unnecessary as the Mediation SDK will set the consent status.automatically based on the latest consent info.

```csharp
// Consent
UnityAdsAdapter.SetGDPRConsentOverride(true);


// No Consent
UnityAdsAdapter.SetGDPRConsentOverride(false);
```

## Set Privacy Consent Override

Use to manually set the consent status on the Unity Ads SDK. This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.

```csharp
// Consent
UnityAdsAdapter.SetPrivacyConsentOverride(true);

// No Consent
UnityAdsAdapter.SetPrivacyConsentOverride(false);
```
