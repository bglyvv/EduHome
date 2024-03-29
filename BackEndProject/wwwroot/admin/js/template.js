(function($) {
  'use strict';
  $(function() {
    var body = $('body');
    var contentWrapper = $('.content-wrapper');
    var scroller = $('.container-scroller');
    var footer = $('.footer');
    var sidebar = $('.sidebar');

    //Add active class to nav-link based on url dynamically
    //Active class can be hard coded directly in html file also as required

    function addActiveClass(element) {
      if (current === "") {
        //for root url
        if (element.attr('href').indexOf("index.html") !== -1) {
          element.parents('.nav-item').last().addClass('active');
          if (element.parents('.sub-menu').length) {
            element.closest('.collapse').addClass('show');
            element.addClass('active');
          }
        }
      } else {
        //for other url
        if (element.attr('href').indexOf(current) !== -1) {
          element.parents('.nav-item').last().addClass('active');
          if (element.parents('.sub-menu').length) {
            element.closest('.collapse').addClass('show');
            element.addClass('active');
          }
          if (element.parents('.submenu-item').length) {
            element.addClass('active');
          }
        }
      }
    }

    var current = location.pathname.split("/").slice(-1)[0].replace(/^\/|\/$/g, '');
    $('.nav li a', sidebar).each(function() {
      var $this = $(this);
      addActiveClass($this);
    })

    //Close other submenu in sidebar on opening any

    sidebar.on('show.bs.collapse', '.collapse', function() {
      sidebar.find('.collapse.show').collapse('hide');
    });


    //Change sidebar

    $('[data-toggle="minimize"]').on("click", function() {
      body.toggleClass('sidebar-icon-only');
    });

    //checkbox and radios
    $(".form-check label,.form-radio label").append('<i class="input-helper"></i>');

    // Remove pro banner on close
    document.querySelector('#bannerClose').addEventListener('click',function() {
      document.querySelector('#proBanner').classList.add('d-none');
    });

  });
    //$("#number_of_speakers").on("keyup", function () {
    //    $("#speaker_number").empty()
    //    var key = $("#number_of_speakers").val();
    //    $.ajax({
    //        url: "/Admin/Event/SpeakerNumber?key=" + key,
    //        type: "Get",
    //        success: function (response) {
    //            console.log(response)
    //            for (let i = 0; i < key; ++i)
    //            {

    //                $("#speaker_number").append(response)
    //            }
    //        }
    //    })
    //})

    $("#search_input").on('keyup', function () {
        let pathx = window.location.pathname;
        let path = pathx.split('/');
        let controller = path[2];
        let action = path[3];
        if (action == undefined) {
            console.log("/Admin/" + controller + "/Search?key=" + $(this).val().trim())
            $.ajax({
                url: "/Admin/" + controller + "/Search?key=" + $(this).val().trim(),
                type: "Get",
                success: function (responsex) {
                    //$("table").css({ "display": "none" })
                    $(".table-responsive").empty();
                    $(".table-responsive").append(responsex)
                }
            })
        }
        else
        {
            $.ajax({
                url: "/Admin/" + controller + "/Search" + action + "?clue=" + $(this).val().trim(),
                type: "Get",
                success: function (response) {
                    $(".table-responsive").empty();
                    $(".table-responsive").append(response)
                }
            })
        }
    })


})(jQuery);