$(document).ready(function (){
   $('.filter-option').on('click', function(e) {
     $(this).siblings('.filter-option-content').toggleClass('filtertoggle');
     $(this).find('.listing').toggleClass('filter-rotate')
     e.stopPropagation();
   });
});
$(document).ready(function () {
  $(".main").click(function (a) {
      $(".sidebar-main").toggleClass('sidebar-active');
      $(".overlay").toggleClass('overlay-active');
      a.stopPropagation();
  });

  $(".sidebar-main").click(function (a) {
      a.stopPropagation();
  });
  
  $(document).click(function () {
      $(".sidebar-main").removeClass('sidebar-active');
      $(".overlay").removeClass('overlay-active');
      
  });

  $('.block-filter h5').click(function (){
    $(".sidebar-main").removeClass('sidebar-active');
    $(".overlay").removeClass('overlay-active');  
  })
});
$(document).ready(function () {
 $('.product-color .color').on('click', function(event){
      event.preventDefault();
          var newImage = $(this).attr('data-image')
            $('.active').removeClass('active'); 
            $('.option-color img[data-image = ' + newImage + ']').addClass('active');
            console.log("newImage" );
            $(this).addClass('active');

            $('.product-color .color').removeClass('active'); 
            $(this).addClass('active'); 


            $(this).find('.product-image-photo').attr('src', newImage);
});
});

$(document).ready(function () {
 $('.product-size .size').on('click', function(event){
      event.preventDefault();
          var newSize = $(this).attr('data-image')
            $('.active').removeClass('active'); 
            $('.option-size img[data-image = ' + newSize + ']').addClass('active');
            console.log("newImage" );
            $(this).addClass('active');
            
            $('.product-size .size').removeClass('active'); 
            $(this).addClass('active'); 


            $(this).find('.product-image-photo').attr('src', newSize);
});
});
