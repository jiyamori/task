$(document).ready(function () {
   
    if ($(window).width() <= 768) {
        $(".footer-col ul").hide();
    }

    $(".footer-col h4").click(function () {
        
        var $ul = $(this).siblings("ul");
        $ul.toggleClass("toggle-content");

        if ($(window).width() <= 768) {
            $(".footer-col ul").not($ul).hide();
            $ul.toggle();
        }
    });

    $(window).resize(function () {
        if ($(window).width() <= 768) {
            $(".footer-col.active ul").show();
            $(".footer-col:not(.active) ul").hide();
        } else {
            $(".footer-col ul").show();
        }
    });
});
