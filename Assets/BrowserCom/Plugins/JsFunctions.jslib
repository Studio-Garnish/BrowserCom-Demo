mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },

  ShowQuestionWindow: function () {
    const event = new Event('showQuestionWindow');
    // Dispatch the event.
    document.body.dispatchEvent(event);
  }

});