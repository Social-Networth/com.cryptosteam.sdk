var LIB = {
  
  //----------------------------------------
  //-- Startup Events
  //----------------------------------------
  
  gameReady: function() {
    return window.PortalSDK.gameReady();
  },

  //----------------------------------------
  //-- Advertisement
  //----------------------------------------
  
  isAdEnabled: function(cb) {
    window.PortalSDK.isAdEnabled().then(response => {
        dynCall_vi(cb, response);
    });
  },
  isAdRunning: function() {
    return window.PortalEmuSDK.isAdRunning();
  },
  reloadAd: function() {
    window.PortalEmuSDK.reloadAd();
  },
  requestAd: function(cb) {
    
    window.PortalSDK.requestAd().then(response => {
        dynCall_vi(cb, response);
    });
  },
  requestRewardAd: function(cb) {
    window.PortalSDK.requestRewardAd().then(response => {
        dynCall_vi(cb, response);
    });
  },
  
  
  
  //----------------------------------------
  //-- SDK Information
  //----------------------------------------
  
  getVersion: function() {
    var str = window.PortalSDK.getVersion();

    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
   
  //----------------------------------------
  //-- Per-App Information
  //----------------------------------------
  
  getConfig: function(cb) {
    window.PortalSDK.getConfig().then(response => {
      var str = JSON.stringify(response)
        
      var bufferSize = lengthBytesUTF8(str) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(str, buffer, bufferSize);
        
      dynCall_vi(cb, buffer);
    });
  },
    
   
  //----------------------------------------
  //-- User
  //----------------------------------------
  
  getProfile: function(cb) {
    window.PortalSDK.getProfile().then(response => {
      
      var str = JSON.stringify(response)
      
      var bufferSize = lengthBytesUTF8(str) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(str, buffer, bufferSize);
      
      dynCall_vi(cb, buffer);
    });
  },
    
  getBalance: function(cb) {
    window.PortalSDK.getBalance().then(response => {
       var str = response.toString()
       
       var bufferSize = lengthBytesUTF8(str) + 1;
       var buffer = _malloc(bufferSize);
       stringToUTF8(str, buffer, bufferSize);
       
       dynCall_vi(cb, buffer);
    });
  },

  getLocale: function() {  
    var str = window.PortalSDK.getLocale();
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer
  },

  //----------------------------------------
  //-- Share
  //----------------------------------------
    
  showSharing: function(url, text) {
      window.PortalSDK.showSharing(url, text)
  },
 
  getStartParam: function() {  
    var str = window.PortalEmuSDK.getStartParam();
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer
  },
  
  //----------------------------------------
  //-- IAP
  //----------------------------------------
  
  openPurchaseConfirmModal: function(itemId, useRect, x, y, width, height, cb) {
    window.PortalSDK.getShopItems().then(response => {
    
      const item = response.find(item => item.id === itemId)
      
      if(!item) {
          const str = 'item not found';
                   
          const bufferSize = lengthBytesUTF8(str) + 1;
          const buffer = _malloc(bufferSize);
          stringToUTF8(str, buffer, bufferSize);
          
          dynCall_vi(cb, buffer);
          return;
      }

      
      var rect = null;
      
      if(useRect) {
        rect = { x, y, width, height }; 
      } 
   
      window.PortalSDK.openPurchaseConfirmModal(item, rect).then(response => {
           
           var str;
           try {
            str = JSON.stringify(response);
           }
           catch(ex) {
            str = "{ \"status\": " + "\"error\"" + "}";
           }
           
           var bufferSize = lengthBytesUTF8(str) + 1;
           var buffer = _malloc(bufferSize);
           stringToUTF8(str, buffer, bufferSize);
           
           dynCall_vi(cb, buffer);
        }).catch(response => {
           const str = "{ \"status\": " + "\"error\"" + "}";
                      
           var bufferSize = lengthBytesUTF8(str) + 1;
           var buffer = _malloc(bufferSize);
           stringToUTF8(str, buffer, bufferSize);
           
           dynCall_vi(cb, buffer);
        });
 
    })  
  },

  getShopItems: function(cb) {
      window.PortalSDK.getShopItems().then(response => {
         
          var str = "{ \"items\": " + JSON.stringify(response) + "}";
          
          var bufferSize = lengthBytesUTF8(str) + 1;
          var buffer = _malloc(bufferSize);
          stringToUTF8(str, buffer, bufferSize);
          
          dynCall_vi(cb, buffer);
      });
  },
    
  getPurchasedShopItems: function(cb) {
      window.PortalSDK.getPurchasedShopItems().then(response => {
          
          var str = JSON.stringify(response);
          
          var bufferSize = lengthBytesUTF8(str) + 1;
          var buffer = _malloc(bufferSize);
          stringToUTF8(str, buffer, bufferSize);
          
          dynCall_vi(cb, buffer);
      });
  },
    

  //----------------------------------------
  //-- Cloud Saves
  //----------------------------------------
  
  setValueSync: function(key, value) {
    window.PortalEmuSDK.setValueSync(UTF8ToString(key), UTF8ToString(value))
  },
  
  getValueSync: function(key) {
      var str = window.PortalEmuSDK.getValueSync(UTF8ToString(key))
      
      if(!str) {
        str = "";
      }
      
      var bufferSize = lengthBytesUTF8(str) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(str, buffer, bufferSize);
      
      return buffer;
  },
  
  removeValue: function(key) {
    window.PortalEmuSDK.removeValueSync(UTF8ToString(key));
  },
    
  setValue: function(key, value) {
    window.PortalSDK.setValue(UTF8ToString(key), UTF8ToString(value))
  },

  getValue: function(key, cb) {
    window.PortalSDK.getValue(UTF8ToString(key)).then(response => {
        var str = response;
                  
        var bufferSize = lengthBytesUTF8(str) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(str, buffer, bufferSize);
        
        dynCall_vi(cb, buffer);
    }).catch(response => {
        var str = "";
                  
        var bufferSize = lengthBytesUTF8(str) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(str, buffer, bufferSize);
        
        dynCall_vi(cb, buffer);
    });
  },

  
  //----------------------------------------
  //-- Achievements
  //----------------------------------------
  
  
  // not implemented
  
  //----------------------------------------
  //-- Game Events
  //----------------------------------------
  
  // not implemented
  
 
}

mergeInto(LibraryManager.library, LIB);