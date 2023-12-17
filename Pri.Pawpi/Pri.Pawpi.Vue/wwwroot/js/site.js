(function () {
    'use strict'
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
    tooltipTriggerList.forEach(function (tooltipTriggerEl) {
        new bootstrap.Tooltip(tooltipTriggerEl)
    })
})()

document.addEventListener('error', function (event) {
    var elm = event.target;
    if (elm.tagName == 'IMG') {
        elm.src = src = '../assets/images/logo.png';
    }
}, true)

