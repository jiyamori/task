
$(document).ready(function() {
      $('.navigation-col').click(function() {
          $(this).find('.nav-category').toggleClass('active');
      });

    // Toggle nav-col when clicking on plus
      $('.plus').click(function(event) {
        event.stopPropagation(); 
        $(this).siblings('ul.nav-col').slideToggle();
        $(this).toggleClass('minus'); 
      });
    //--- Toggle nav-col end---//

    //--sub-menu-last level start---//
      $('.level-four').click(function(event) {
        event.stopPropagation(); 
        $(this).siblings('ul.nav-list').slideToggle();
        $(this).toggleClass('minus'); 
      }); 
    //---sub-menu last section end---//

    //--icon start---//
      $('#search-icon-link').click(function(){
        $('.main-menu').toggle();
        $('.input-search').toggleClass('.input-active');
        $('.search-icon').toggleClass('cross-icon');
      });

      $('.profile-icon').click(function(a){
        $('.account').toggleClass('account-active');
        $(".overlay").toggleClass('overlayactive');
        a.stopPropagation();
      });
     
      $(".account").click(function (a) {
        a.stopPropagation();
      });

      $('.offcanvas-cross').click(function(){
        $('.account').removeClass('account-active');
        $(".overlay").removeClass('overlayactive');
      });

      $(".shopping-icon").click(function (a) {
        $(".offcanvas-cart").toggleClass('offcanvas-active');
        $(".overlay").toggleClass('overlay-active');
        a.stopPropagation();
      });

      $(".offcanvas-cart").click(function (a) {
        a.stopPropagation();
      });

      $('.close-btn').click(function(){
          $('.offcanvas-cart').removeClass('offcanvas-active');
          $(".overlay").removeClass('overlay-active');  
      });

      $(document).click(function () {
        $(".offcanvas-cart").removeClass('offcanvas-active');
        $(".overlay").removeClass('overlay-active');  
      });
    //--- icon end---//
      
    //---nav-bar scroll start---//
      $(window).scroll(function() {
				if ($(window).scrollTop()) {
					$('#scroller').addClass('stuck');
				} else {
					$('#scroller').removeClass('stuck');
				}
			});
     //---nav-bar scroll end---//

     //---hamburger-icon start---//
      $(".hamburger-menu ").click(function (a) {
        $(".nav-menu").toggleClass('nav-active');
        $(".overlay").toggleClass('overlay-active');
        a.stopPropagation();
      });
      
      $(".nav-menu").click(function (a) {
        a.stopPropagation();
      }); 

      $(document).click(function () {
        $(".nav-menu").removeClass('nav-active');
      });  
       
      $('.offcanvas-cross').click(function(){
        $(".nav-menu").removeClass('nav-active');
        $(".overlay").removeClass('overlay-active');
      });
    //---hamburger-icon end---//

     //--hambuer section continue----//
      $('.plus').click(function(){
       $('.nav-col').addClass('navcol-active');
      });

      $(".nav-col").click(function (a) {
        a.stopPropagation();
      }); 

      $('li.zaruck.neu-link a').click(function () {
        $(".nav-col").removeClass('navcol-active');
      });  
     
      $('.level-four').click(function(){
        $('.nav-list').addClass('canvas-list');
      });
     
      $('.hamburger-bar').click(function(){
        $('.nav-category').removeClass('active');
        $(".nav-col").removeClass('navcol-active');
        $('.nav-list').removeClass('canvas-list');
      });
      //--hamburger end---//
      
      // ---footer section start---//

      $('.contact').click(function() {
        $(this).find('.timezone-contact').toggleClass('footer-active');
        $(this).find('.subscribe').toggleClass('footer-active');
        $(this).find('.contact-heading').toggleClass('rotate-down');
      });
     //--- footer section end---//
});

