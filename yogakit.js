$(document).ready(function () {
   $('.bundle-actions button ').on('click', function () {
      $('.bundle-option-container').addClass('.active')
   });

   // CODE OF PRODUCT CALCULATE START //

   var initialprice = 5.00;
   var finalqtyInput = $('.block-bundle-summary').find('.final-qty');

   function updateTotalPrice() {
      var totalPrice = 0;
      totalPrice += initialprice;

      // ---Code for option-select start---//
      $(".single-bundle-select option:selected").each(function () {
         var fieldqty = $(this).closest('.field-option-required').find('.quantity-number').val();
         var selectPrice = parseInt($(this).data("price"));
         totalPrice += isNaN(selectPrice) ? 0 : fieldqty * selectPrice;
      });
      //--- option-select code end ---//

      //---code for radio-container start---//
      $(".field-option-required.option-list input[type='radio']:checked").each(function () {
         var fieldqty = $(this).closest('.field-option-required').find('.quantity-number').val();
         var radioPrice = parseInt($(this).siblings("label").find(".price-wrapper").data("price"));
         totalPrice += isNaN(radioPrice) ? 0 : fieldqty * radioPrice;
      });
      //--radio-container code end---//

      //---code for check-box start---//
      $(".field-option-required.option-list input[type='checkbox']:checked").each(function () {
         var fieldqty = $(this).closest('.field-option-required').find('.quantity-number').val();
         var checkboxPrice = parseInt($(this).siblings("label").find(".price-wrapper").data("price"));
         totalPrice += isNaN(checkboxPrice) ? 0 : fieldqty * checkboxPrice;
      });
      //---check-box container code end---//

      //---code for multiple container start---//
      $(".option-list option:selected").each(function () {
         var fieldqty = $(this).closest('.field-option-required').find('.quantity-number').val();
         var multiplePrice = parseInt($(this).data("price"));
         totalPrice += isNaN(multiplePrice) ? 0 : fieldqty * multiplePrice;
      });
      //---multiple container code end---//

      var finalqty = parseInt(finalqtyInput.val());
      $(".final-price ").text("$" + (totalPrice * finalqty).toFixed(2));
   };

   $(".single-bundle-select, .option-list input[type='radio'],.option-list input[type='checkbox'],.option-list select").change(updateTotalPrice);
   $(".quantity-number").on("input", updateTotalPrice);
   $(".final-qty").on("input", updateTotalPrice);

      //initial price//
      updateTotalPrice();
 
   //SUMMARY CODE START //
   function updateSummaryInfo() {
      var summaryInfo = "";
      var finalInput = $('.block-bundle-summary').find('.quantity-number.final-qty');

      $('.field-option-required').each(function () {
         var optionLabel = $(this).find('.field-option-label').text();
         var selectedProductName = "";
         var fieldqty = $(this).find('.field-qty').val();
         fieldqty = !isNaN(fieldqty) ? parseInt(fieldqty): 0 ;

         if ($(this).find('select').hasClass('single')){
            var selectOption = $(this).find('.single-bundle-select option:selected');
               if(selectOption.text() !== "Choose a selector"){
                  selectedProductName = selectOption.text();
               }
         }
         else if ($(this).find('input[type="radio"]').is(':checked')) {
            selectedProductName = $(this).find('.radio-product:checked').siblings('.label').find('.product-name').text();
         }
         else if ($(this).find('input[type="checkbox"]').is(':checked')) {
            $(this).find('input[type="checkbox"]:checked').each(function(){
               selectedProductName += $(this).siblings('.label').find('.product-name').text() + "<br>";
            });
         }
         else if ($(this).find('select').hasClass('multiple')){
            $(this).find('option:selected').each(function(){
               selectedProductName += $(this).text() + "<br>";
            });
            
         }

         var finalqty = parseInt(finalInput.val());
         if (selectedProductName !== "") {
            var totalPrice = fieldqty * finalqty;
            summaryInfo += '<div class="summary-data">' + '<p style="font-weight:800;">' + optionLabel + ':' + '</p>' + totalPrice + 'x' + selectedProductName +'</div>';
         }
      });
         $('#bundle-summary-info').html(summaryInfo);
   }
         
      updateSummaryInfo();

      $(".bundle-option-container").on('input change',  '.single-bundle-select .select.single option:selected,select, input[type="radio"], input[type="checkbox"], quantity-number.final-qty, .field-qty.qty,  quantity-number.field-qty',
         updateSummaryInfo);
      $(".bundle-option-container").on('input change' , updateSummaryInfo);

   // SUMMARY CODE END //
   
});

function checkQuantity(input){
   var value = $('input').val();
   var errorMgs = input.parentNode.querySelector('.error-msg');
      if (value < 1) {
         errorMgs.style.display ="block";
      } 
      else {
         errorMgs.style.display ="none";
      }
}