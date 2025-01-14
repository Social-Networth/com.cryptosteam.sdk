mergeInto(LibraryManager.library, {
  
  //----------------------------------------
  //-- Advertisement
  //----------------------------------------
  
  isAdEnabled: function(cb) {
    window.CryptoSteamSDK.isAdEnabled().then(response => {
        dynCall_vi(cb, response);
    });
  },
  isAdRunning: function() {
    return window.CryptoSteamEmuSDK.isAdRunning();
  },
  reloadAd: function() {
    window.CryptoSteamEmuSDK.reloadAd();
  },
  requestAd: function() {
    return window.CryptoSteamEmuSDK.requestAd();
  },
  
  //----------------------------------------
  //-- SDK Information
  //----------------------------------------
  
  getVersion: function() {
    var str = window.CryptoSteamSDK.getVersion();

    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
   
  //----------------------------------------
  //-- Per-App Information
  //----------------------------------------
  
  getConfig: function() {
    var str = JSON.stringify(window.CryptoSteamSDK.getConfig().config);
  
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
    
   
  //----------------------------------------
  //-- User
  //----------------------------------------
  
  getProfile: function(cb) {
    window.CryptoSteamSDK.getProfile().then(response => {
      
      var str = JSON.stringify(response)
      
      var bufferSize = lengthBytesUTF8(str) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(str, buffer, bufferSize);
      
      dynCall_vi(cb, buffer);
    });
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

  getLocale: function() {  
    var str = window.CryptoSteamSDK.getLocale();
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer
  },

  //----------------------------------------
  //-- Share
  //----------------------------------------
    
  showSharing: function(url, text) {
      window.CryptoSteamSDK.showSharing(url, text)
  }
 
  getStartParam: function() {  
    var str = window.CryptoSteamEmuSDK.getStartParam();
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer
  },
  
  //----------------------------------------
  //-- IAP
  //----------------------------------------
  
  openPurchaseConfirmModal: function(itemId, cb) {
    window.CryptoSteamSDK.getShopItems().then(response => {
    
      const item = response.find(item => item.id === itemId)
      
      if(!item) {
          const str = 'error'
                   
          const bufferSize = lengthBytesUTF8(str) + 1;
          const buffer = _malloc(bufferSize);
          stringToUTF8(str, buffer, bufferSize);
          
          dynCall_vi(cb, buffer);
          return;
      }
      
      // debug
      console.log(item);
    
      window.CryptoSteamSDK.openPurchaseConfirmModal(item).then(response => {
           var str = JSON.stringify(response);
           
           var bufferSize = lengthBytesUTF8(str) + 1;
           var buffer = _malloc(bufferSize);
           stringToUTF8(str, buffer, bufferSize);
           
           dynCall_vi(cb, buffer);
        });
    
    
    })  
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
    

  //----------------------------------------
  //-- PlayerPrefs
  //----------------------------------------
  
  setValue: function(key, value) {
    window.CryptoSteamSDK.setValue(key, value)
  }

  getValue: function(key) {
      var str = window.CryptoSteamSDK.getValue(key);
      var bufferSize = lengthBytesUTF8(str) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(str, buffer, bufferSize);
      return buffer
  }
 
  removeValue: function(key) {
      var str = window.CryptoSteamSDK.removeValue(key);
      var bufferSize = lengthBytesUTF8(str) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(str, buffer, bufferSize);
      return buffer
  }
  
  //----------------------------------------
  //-- Achievements
  //----------------------------------------
  
  // not implemented
  
  //----------------------------------------
  //-- Game Events
  //----------------------------------------
  
  // not implemented
  
 
});