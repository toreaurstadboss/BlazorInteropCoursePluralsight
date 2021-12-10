
var blazorInterop = blazorInterop || {};

blazorInterop.showAlert = function showAlert(message) {
    alert(message);
}

blazorInterop.logToConsoleTable = function (obj) {
    console.table(obj);
}

blazorInterop.showPrompt = function (message, defaultValue) {
    return prompt(message, defaultValue); 
}

blazorInterop.createEmployee = function (firstName, lastName) {
    return { firstName: firstName, lastName: lastName, email: firstName + "thomasclaudiushuber.com" };
}

blazorInterop.focusElement = function (element) {
    element.focus();
}

blazorInterop.focusElementById = function (id) {
    var element = document.getElementById(id);
    if (element) {
        element.focus();
    }
}

blazorInterop.throwsError = function () {
    throw Error("This did not work");
}

blazorInterop.callStaticDotNetMethod = function () {
    var promise = DotNet.invokeMethodAsync("BethanysPieShopHRM.ServerApp", "BuildEmail", "test");
    promise.then(email => alert(email));
}

blazorInterop.callStaticDotNetMethodCustomIdentifier = function () {
    var promise = DotNet.invokeMethodAsync("BethanysPieShopHRM.ServerApp", "BuildEmailWithLastName", "test", "testsurename");
    promise.then(email => alert(email));
}

blazorInterop.callDotNetInstanceMethod = function (dotNetObjectRef) {
    dotNetObjectRef.invokeMethodAsync("SetWindowSize",
        {
            width: window.innerWidth,
            height: window.innerHeight
        });
}

blazorInterop.registerResizeHandler = function (dotNetObjectRef) {

    function resizeHandler() {
        dotNetObjectRef.invokeMethodAsync("SetWindowSize",
            {
                width: window.innerWidth,
                height: window.innerHeight
            });
    }

    //setup initial values 
    resizeHandler();

    //register event handler 
    window.addEventListener("resize", resizeHandler);
}

blazorInterop.registerOnlineHandler = function (dotNetObjectRef) {

    function onlineHandler() {
        dotNetObjectRef.invokeMethodAsync("SetOnlineStatus",
            navigator.onLine);
    }

    //setup initial values 
    onlineHandler();

    //register event handler 
    window.addEventListener("online", onlineHandler);
    window.addEventListener("offline", onlineHandler);

}



