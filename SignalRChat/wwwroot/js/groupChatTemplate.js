
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();
connection.on("Send", function (message, username) {
    var ul = document.createElement("ul");
    var li = document.createElement("li");
    var span = document.createElement("span");
    span.className = "message-time pull-right";
    var d = new Date();
    var n = d.toLocaleTimeString();
    span.innerText = n;
    li.textContent = message;
    li.appendChild(span);
    
    if (currentUser == username) {

        ul.className = 'message-main-sender';
        li.className = 'sender';
        ul.appendChild(li);
        document.getElementById('here').appendChild(ul);

    }
    else {

        ul.className = 'message-main-receiver';
        li.className = 'receiver';

        ul.appendChild(li);
        document.getElementById('here').appendChild(ul);
    }


});
connection.on("Get", function (connectionid) {
    connectionId = connectionid;
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

document.getElementById("groupmsg").addEventListener("mouseover", async (event) => {
    //var groupName = document.getElementById("group-name").value;
    document.getElementById("groupmsg").className = "fa fa-send-o fa-2x";
    event.preventDefault();
});
document.getElementById("groupmsg").addEventListener("mouseout", async (event) => {
    //var groupName = document.getElementById("group-name").value;
    document.getElementById("groupmsg").className = "fa fa-send fa-2x";
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






    