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

function changeBackgroundImage(url) {
    // var body = document.getElementsByTagName('body')[0];
    // body.style.background = 'url('+url+') 50px 75px no-repeat';
    // body.style.backgroundColor = '#272727';
    // body.style.marginBottom= '100px';
    
}