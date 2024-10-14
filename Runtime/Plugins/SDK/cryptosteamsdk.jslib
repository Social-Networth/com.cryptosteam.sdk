mergeInto(LibraryManager.library, {
  
  getConfig: function() {
    var str = JSON.stringify(window.CryptoSteamSDK.getConfig().config);
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  createReceipt: function() {
    var str = window.CryptoSteamSDK.createReceipt();
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  isAdEnabled: function() {
    return window.CryptoSteamSDK.isAdEnabled();
  },
  
  getProfile: function() {
    var str = JSON.stringify(window.CryptoSteamSDK.getProfile().profile);
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  trackLaunch: function() {
    window.CryptoSteamSDK.trackLaunch();
  },
  
  getVersion: function() {
    var str = window.CryptoSteamSDK.getVersion();
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
   isAdRunning: function() {
      return window.CryptoSteamSDKLocal.isAdRunning();
   },
   
   runAd: function() {
     return window.CryptoSteamSDKLocal.runAd();
   },
    
});