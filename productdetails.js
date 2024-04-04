$(document).ready(function () {
    $('.slider-for').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: true,
        fade: true,
        asNavFor: '.slider-nav',
        responsive: [
            {
                breakpoint: 1024,
                settings:{
                    slidesToShow:1,
                    slidesToScroll:1,
                    dots:false,
                    arrows:true,
                    
                }
            },
            {
                breakpoint: 769,
                settings:{
                    slidesToShow:1,
                    slidesToScroll:1,
                    arrows:false,
                    dots:true,
                }
            }, 
        ]
    });
          
    $('.slider-nav').slick({
            slidesToShow: 5,
            slidesToScroll: 1,
            asNavFor: '.slider-for',
            dots: false,
            arrows:false,
            vertical: true,
            verticalSwiping: true,
            focusOnSelect: true
        });

    $('.fotorama').mouseenter(function(){
        $('.slick-prev').show();
        $('.slick-next').show();
    });

    $('.fotorama').mouseleave(function(){
        $('.slick-prev').hide();
        $('.slick-next').hide();
    });

    $('.related-products').slick({
        slidesToShow:4,
        slidesToScroll:1,
        dots: false,
        arrows:true,
        fade:false,
        responsive: [
            {
                breakpoint: 1023,
                settings:{
                    slidesToShow:3,
                    slidesToScroll:1,
                    dots:false,
                    arrows:false,
                },
            },
            {  
                breakpoint: 768,
                settings:{
                    slidesToShow:3,
                    slidesToScroll:1,
                    dots:false,
                    arrows:false, 
                },
            },
            {
                breakpoint: 640,
                settings:{
                    slidesToShow:2,
                    slidesToScroll:1,
                    dots:false,
                    arrows:false, 
                },
            },
        ]
    });

     var $box=null;
        $('.slider-nav img ').click(function() {
            if ($box == null) 
                {
                $box = $(this);
                $box.css("border","2px solid red");
                } 
            else 
                {
                $box.css("border","1px solid white");
                if($box != $(this))
                {
                    $box = $(this);
                    $box.css("border","1px solid red");
                }
                else
                    $box = null;
                }
        });

    $('.data-switch').click(function() {
        $('.product-data a').removeClass('active');
        $('.product-describe').removeClass('active');
        $(this).addClass('active');
        var index = $('.data-switch').index(this);
        $('.product-describe').eq(index).addClass('active');
    });

    $(".mobile-menu").click(function (a) {
        $(".cl-menu").toggleClass('classic-active');
        $(".overlay").toggleClass('overlay-active');
        a.stopPropagation();
    });

    $(".cl-menu").click(function (a) {
        a.stopPropagation();
    });

        $(document).click(function () {
        $(".cl-menu").removeClass('classic-active');
        $(".overlay").removeClass('overlay-active');  
    });

    var isSmallScreen = $(window).width() < 769;
        $(".comman-menu").click(function () {
            if (isSmallScreen) {
                $(this).find('.slide').toggleClass('rotate-180');
                var submenu = $(this).find('.submenu');
                submenu.slideToggle('slow');
                }
        });

    $('.fotorama-color.color').on('click', function(){
        var swatchId = $(this).attr('data-id');
            if($('#'+swatchId).hasClass('active'))
            {
                $('#'+swatchId).toggleClass('active'); 
            } 
            else 
            {
                $('.image').removeClass('active');
                $('#'+swatchId).addClass('active');     
            }
    });
});   
