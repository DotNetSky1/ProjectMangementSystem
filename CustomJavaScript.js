jQuery(document).ready(function ($) {
    $(".clickable-row").click(function () {
        window.location = $(this).data("href");
    });
});



$(document).ready(function(){
  $("#myInput").on("keyup", function() {
    var value = $(this).val().toLowerCase();
    $("#myTable tr").filter(function() {
      $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
    });
  });
});


$(document).ready(function () {
    $('input').keyup(function () {
        $.ajax({ url: "imagesz\\" + document.getElementById('membershipno').value, success: function (result) {
            $("#div2").html(result);
        } 
        });
    });
});



