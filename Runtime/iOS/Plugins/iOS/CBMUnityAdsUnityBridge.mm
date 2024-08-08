#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterUnityAds/ChartboostMediationAdapterUnityAds-Swift.h>

extern "C" {

    const char * _CBMUnityAdsAdapterAdapterVersion(){
        return toCStringOrNull([UnityAdsAdapterConfiguration adapterVersion]);
    }

    const char * _CBMUnityAdsAdapterPartnerSDKVersion(){
        return toCStringOrNull([UnityAdsAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMUnityAdsAdapterPartnerId(){
        return toCStringOrNull([UnityAdsAdapterConfiguration partnerID]);
    }

    const char * _CBMUnityAdsAdapterPartnerDisplayName(){
        return toCStringOrNull([UnityAdsAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMUnityAdsAdapterGetTestMode(){
        return [UnityAdsAdapterConfiguration debugMode];
    }

    void _CBMUnityAdsAdapterSetTestMode(BOOL testMode){
        [UnityAdsAdapterConfiguration setDebugMode:testMode];
    }

    void _CBMUnityAdsAdapterSetGDPRConsentOverride(BOOL gdprStatus){
        [UnityAdsAdapterConfiguration setGDPRConsentOverride:gdprStatus];
    }

    void _CBMUnityAdsAdapterSetPrivacyConsentOverride(BOOL consentStatus){
        [UnityAdsAdapterConfiguration setPrivacyConsentOverride:consentStatus];
    }
}
