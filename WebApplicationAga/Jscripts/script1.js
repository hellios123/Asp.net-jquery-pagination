$(document).ready(function () {
    var url_string = window.location.href;

    var url = new URL(url_string);
    var paramValue = url.searchParams.get('id');
    var ttt = 0;
    if (window.location.href.indexOf("?") != -1) {
        if (!!window.location.href.split('?')[1].split('=')[1])
            ttt = window.location.href.split('?')[1].split('=')[1]
    };



    $(document).find(".xxx").each(function (i, value) {
        if (parseInt($(this).text()) == parseInt(ttt) + 1) {
            $(this).addClass("btn-info"); $(this).siblings(".xxx").removeClass("btn-info");



        }
    })
    $(document).find(".xxx").hover(function () { $(this).css({ "color": "blue", "text-decoration": "underline" }); },
        function () { $(this).css({ "color": "black", "text-decoration": "none" }); }) 

    $(document).find(".xxx").each(function (i, el) {
        if (parseInt($(this).text()) == parseInt(ttt) + 1) {   
            $(this).hover(function () { $(this).css({ "background-color": "red", "text-decoration": "underline" }); },
                function () { $(this).css({ "background-color": "#5bc0de", "text-decoration": "none", "color": "white" }); })
        }
    })



})