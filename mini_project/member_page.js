function alertMessage() {
    alert('Please fill the required fields');
}

function showhide() {
    var div = document.getElementById("showbox");
    if (div.style.display !== "none") {
        div.style.display = "none";
    }
    else {
        div.style.display = "block";
    }
}

function issuemessage() {
    alert('Book issued');
}


function returnmessage() {
    alert('Book returned');
}

function notissued() {
    alert('Error in issuing book');
}
