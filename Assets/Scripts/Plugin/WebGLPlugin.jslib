mergeInto(LibraryManager.library, {
    SendCounterData: function (counter) {
		console.log(counter);
        receiveDataFromUnity(counter);
    }
});
mergeInto(LibraryManager.library, {
    SendCartData: function (ProductID, Amount){
		console.log(ProductID, Amount);
		receiveCartDataFromUnity(ProductID, Amount)
	}
});

	
