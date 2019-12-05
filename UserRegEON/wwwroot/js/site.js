const uri = 'api/UsersAPI';
let users = [];

function getUsers() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayUsers(data))
        .catch(error => console.error('Unable to get Users.', error));
}

//Display users from database
function _displayUsers(data) {
    const tBody = document.getElementById('users');
    tBody.innerHTML = '';

    const button = document.createElement('button');

    data.forEach(user => {
        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let textNode = document.createTextNode(user.id);
        td1.appendChild(textNode);

        let td2 = tr.insertCell(1);
        let textNode1 = document.createTextNode(user.name);
        td2.appendChild(textNode1);

        let td3 = tr.insertCell(2);
        let textNode2 = document.createTextNode(user.email);
        td3.appendChild(textNode2);

        let td4 = tr.insertCell(3);
        let textNode3 = document.createTextNode(user.gender);
        td4.appendChild(textNode3);

        let td5 = tr.insertCell(4);
        let textNode4 = document.createTextNode(user.dateRegistered);
        td5.appendChild(textNode4);

        let td6 = tr.insertCell(5);
        let textNode5 = document.createTextNode(user.days);
        td6.appendChild(textNode5);

        let td7 = tr.insertCell(6);
        let textNode6 = document.createTextNode(user.requests);
        td7.appendChild(textNode6);
    });

    users = data;
}