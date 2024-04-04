$(document).ready(function (){
    $('.dropdown').on('click',function () {
       $(this).siblings('.section-info').toggleClass('active');
    })
    $('.dropdown').click(function() {
     $(this).find('.rotate').toggleClass('down');
     });
    
  });
  