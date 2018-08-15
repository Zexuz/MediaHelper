function addTooltip() {
    init()
}

function init() {
    M.Tooltip.init(document.querySelectorAll('.tooltipped'));
    M.Modal.init(document.querySelectorAll('.modal'));
    M.Collapsible.init(document.querySelectorAll('.collapsible'));
    M.Sidenav.init(document.querySelectorAll('.sidenav'));
    M.Tabs.init(document.querySelectorAll('.tabs'));
    console.log("started");
}