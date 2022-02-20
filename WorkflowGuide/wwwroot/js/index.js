window.addEventListener('DOMContentLoaded', function () {
    const categoriesSelect = document.getElementById('categories');

    const categoriesChoices = new Choices(categoriesSelect, {
    });
})

const startBtn = document.getElementById('startBtn');

startBtn.addEventListener('click', function () {
    start();
});

async function postData(url = '', data = {}) {
    // Default options are marked with *
    const response = await fetch(url, {
        method: 'POST', // *GET, POST, PUT, DELETE, etc.
        mode: 'cors', // no-cors, *cors, same-origin
        cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
        credentials: 'same-origin', // include, *same-origin, omit
        headers: {
            'Content-Type': 'application/json'
            // 'Content-Type': 'application/x-www-form-urlencoded',
        },
        redirect: 'follow', // manual, *follow, error
        referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
        body: JSON.stringify(data) // body data type must match "Content-Type" header
    });
    return response.json(); // parses JSON response into native JavaScript objects
}

function start() {
    const pName = document.getElementById('project');
    const category = document.getElementById('categories');
    const description = document.getElementById('description');

    if (!pName.value || !category.value || !description.value) {
        return;
    }


    fetch('/Api/PartNumber', {
        method: "POST",
        body: JSON.stringify({ "ProjectName": pName.value, "Category": category.value, "Description": description.value }),
        headers: { "Content-type": "application/json; charset=UTF-8" }
    }).then(response => response.json())
        .then(json => console.log(json))
        .catch(err => console.log(err));

    //postData('/Api/PartNumber', { "ProjectName": pName.value, "Category": category.value, "Description": description.value }).then(data => {
    //    console.log(data);
    //});
}
