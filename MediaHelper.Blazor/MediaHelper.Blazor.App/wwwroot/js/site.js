function addTooltip() {
    init()
    document.addEventListener('DOMContentLoaded', function() {
       init()
    });
}

function init() {
    M.Tooltip.init(document.querySelectorAll('.tooltipped'));
    M.Modal.init(document.querySelectorAll('.modal'));
    M.Collapsible.init(document.querySelectorAll('.collapsible'));
    console.log("started");
}