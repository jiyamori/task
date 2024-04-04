$(document).ready(function () {
          $(".banner-slider").slick({
              arrows: true,
              infinite: false,
              slidesToShow: 1,
              responsive: [
                {
                  breakpoint: 1025,
                  settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                  }
                },
              ]
            });

          $(".destination-slider").slick({
              infinite: false,
              slidesToShow: 4,
              slidesToScroll: 1,
              responsive: [
                {
                  breakpoint: 1024,
                  settings: {
                    slidesToShow: 2.1,
                    slidesToScroll: 1,
                    infinite: false,
                  }
                },
                {
                  breakpoint: 768,
                  settings: {
                    slidesToShow: 2.1,
                    slidesToScroll: 1,
                    infinite: false,
                  
                  }
                },
                {
                  breakpoint: 430,
                  settings: {
                    slidesToShow: 1.1,
                    slidesToScroll: 1,
                  }
                },
              ]
            });

            $(".testimonial-slider").slick({
              dots: false,
              infinite: false,
              slidesToShow: 3,
              slidesToScroll: 1,
              responsive: [
                {
                    breakpoint: 1024,
                    settings:{
                        slidesToShow:2,
                        slidesToScroll:1,
                  }
                },
                {
                  breakpoint: 767,
                  settings:{
                      slidesToShow:1,
                      slidesToScroll:1,
                  }
                },
              ]
            });

          $('.fotorama-color.color').on('click', function(){
              $('.image').removeClass('active');
              var swatchId = $(this).attr('data-id');
              $('.image').removeClass('active');
              $('#'+swatchId).addClass('active'); 
            });

          $('.nav-bar').on('click', function (e) {
                $('.name').toggleClass('menu');
                $('.overlay').toggleClass('.overlay-active');
                e.stopPropagation();

            $('.name').click(function (e) {
              e.stopPropagation();
            });

            $('body,html').click(function (e) {
              $('.name').removeClass('menu');
              $('.overlay').removeClass('.overlay-active');
              e.stopPropagation();
            });

            $('.close').on('click', function (e) {
              $('.name').removeClass('menu');
              $('.overlay').removeClass('.overlay-active');
              e.stopPropagation();
            });

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
            $(".menu2, .menu3, .menu4, .menu5").click(function () {
              if (isSmallScreen) {
                  $(this).find('.slide').toggleClass('rotate-180');
                  var submenu = $(this).find('.submenu');
                    submenu.slideToggle('slow');
                }
            });

});