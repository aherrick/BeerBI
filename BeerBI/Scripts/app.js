


$(document).on('change', '.btn-file :file', function () {

    var data = new FormData();
    var files = $(this).get(0).files;

    if (files.length > 0) {
        data.append("UploadedBeers", files[0]);

        debugger;
        var dataType = $("#beerbi-tabs li.active a").text();
        data.append("DataType", dataType);
    }

    var ajaxRequest = $.ajax({
        type: "POST",
        url: "/home/UploadBeers",
        contentType: false,
        processData: false,
        data: data
    });

    ajaxRequest.done(function (xhr, textStatus) {
        // Do other operation
    });
});

