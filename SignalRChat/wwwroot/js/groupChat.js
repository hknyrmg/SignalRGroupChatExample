
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();
connection.on("Send", function (message, username) {

    var li = document.createElement("li");
    li.textContent = message;
    if (currentUser == username) {
        li.className = "list-group-item active right";
    }
    else {
        li.className = "list-group-item warning";

    }
        document.getElementById("messagesList").appendChild(li);
});
connection.on("Get", function (connectionid) {
    connectionId = connectionid;
});

//setting enter key to send message
// Get the input field
var input = document.getElementById("group-message-text");

// Execute a function when the user releases a key on the keyboard
input.addEventListener("keyup", function (event) {
    // Cancel the default action, if needed
    // Number 13 is the "Enter" key on the keyboard
    event.preventDefault();
    if (event.keyCode === 13) {
        // Trigger the button element with a click
        document.getElementById("groupmsg").click();
    }
    event.preventDefault();

});
document.getElementById("groupmsg").addEventListener("click", async (event) => {

    //var groupName = document.getElementById("group-name").value;
    var groupMsg = document.getElementById("group-message-text").value;
    try {
        await connection.invoke("SendMessageToGroup", currentUser, groupName, groupMsg);
        document.getElementById("group-message-text").value = "";
    }
    catch (e) {
        console.error(e.toString());
    }
    event.preventDefault();
});


//document.getElementById("join-group").addEventListener("click", async (event) => {

//    //var groupName = document.getElementById("group-name").value;

//    try {

//        await connection.invoke("AddToGroup", userName, groupName);
//    }
//    catch (e) {
//        console.error(e.toString());
//    }
//    event.preventDefault();
//});


document.getElementById("leave-group").addEventListener("click", async (event) => {
    //var groupName = document.getElementById("group-name").value;
    try {
        await connection.invoke("RemoveFromGroup", userName, groupName);
    }
    catch (e) {
        console.error(e.toString());
    }
    event.preventDefault();
});




// We need an async function in order to use await, but we want this code to run immediately,
// so we use an "immediately-executed async function"
(async () => {
    try {
        await connection.start();
        //after page loaded, chat starts.
        await connection.invoke("AddToGroup", userName, groupName);
    }
    catch (e) {
        console.error(e.toString());
        setTimeout(() => start(), 5000);

    }
})();