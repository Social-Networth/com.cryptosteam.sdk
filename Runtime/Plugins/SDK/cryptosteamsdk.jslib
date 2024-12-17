mergeInto(LibraryManager.library, {
  
  
  getConfig: function() {
    var str = JSON.stringify(window.CryptoSteamSDK.getConfig().config);
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  createReceipt: function(number, amount) {
    var str = window.CryptoSteamSDK.createReceipt(number, amount);
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  isAdEnabled: function(cb) {
    window.CryptoSteamSDK.isAdEnabled().then(response => {
        dynCall_vi(cb, response);
    });
  },
  
  getProfile: function(cb) {
    window.CryptoSteamSDK.getProfile().then(response => {
        
        var str = JSON.stringify(response)
        
        var bufferSize = lengthBytesUTF8(str) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(str, buffer, bufferSize);
        
        dynCall_vi(cb, buffer);
    });
  },
  
  getShopItems: function(cb) {
    window.CryptoSteamSDK.getShopItems().then(response => {
        
        var str = "{ \"items\": " + JSON.stringify(response) + "}";
        
        var bufferSize = lengthBytesUTF8(str) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(str, buffer, bufferSize);
        
        dynCall_vi(cb, buffer);
    });
  },
  
  getPurchasedShopItems: function(cb) {
    window.CryptoSteamSDK.getPurchasedShopItems().then(response => {
        
        var str = JSON.stringify(response);
        
        var bufferSize = lengthBytesUTF8(str) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(str, buffer, bufferSize);
        
        dynCall_vi(cb, buffer);
    });
  },
  
  getVersion: function() {
    var str = window.CryptoSteamSDK.getVersion();
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },

  getBalance: function(cb) {
    window.CryptoSteamSDK.getBalance().then(response => {
       var str = response.toString()
       
       var bufferSize = lengthBytesUTF8(str) + 1;
       var buffer = _malloc(bufferSize);
       stringToUTF8(str, buffer, bufferSize);
       
       dynCall_vi(cb, buffer);
    });
  },
  
  buyShopItem: function(itemId, cb) {
    window.CryptoSteamSDK.buyShopItem(itemId).then(response => {
       var str = 'ok'
       
       var bufferSize = lengthBytesUTF8(str) + 1;
       var buffer = _malloc(bufferSize);
       stringToUTF8(str, buffer, bufferSize);
       
       dynCall_vi(cb, buffer);
    });
  },

  // Emu methods
  isAdRunning: function() {
     return window.CryptoSteamEmuSDK.isAdRunning();
  },
  reloadAd: function() {
     window.CryptoSteamEmuSDK.reloadAd();
  },
  
  emuRequestAd: function() {
     return window.CryptoSteamEmuSDK.requestAd();
  },
  
  getStartParam: function() {
  
    var str = window.CryptoSteamEmuSDK.getStartParam();
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer
  },
  
  showSharing: function(param) {
    window.CryptoSteamSDK.showSharing(param)
  }
  
});