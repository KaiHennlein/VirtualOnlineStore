mergeInto(LibraryManager.library, {
    SendCounterData: function (counter) {
		console.log(counter);
        receiveDataFromUnity(counter);
    }
});
