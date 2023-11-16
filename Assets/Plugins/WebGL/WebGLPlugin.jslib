mergeInto(LibraryManager.library, {
    SendCounterData: function (counter) {
		console.log(counter);
        receiveDataFromUnity(counter);
    }
});
mergeInto(LibraryManager.library, {
    SendCartData: function (ProductName, ProductID, Amount){
		console.log(ProductName, ProductID, Amount);
		receiveCartDataFromUnity(ProductName, ProductID, Amount)
	}
});

	
