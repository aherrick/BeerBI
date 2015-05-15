


$(document).on('change', '.btn-file :file', function () {

    var data = new FormData();
    var files = $(this).get(0).files;

    if (files.length > 0) {
        data.append("UploadedBeers", files[0]);

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

$('#beerbi-tabs a').on('click', function (e) {
    var href = $(this).attr('href');
    var type = href.replace('#beerbi-', '');
    var rows;

    $.get('/home/JSONGet' + type, function (data) {
        if (data.length) {
            if (type == 'beers')
            {
                rows = ich.beerList({ tmpl: data });
            } else if (type == 'breweries')
            {
                rows = ich.breweryList({ tmpl: data });
            } else if(type == 'geocodes')
            {
                rows = ich.geocodeList({ tmpl: data });
            } else if (type == 'styles')
            {
                rows = ich.styleList({ tmpl: data });
            } else if (type == 'categories')
            {
                rows = ich.categoryList({ tmpl: data });
            }
        } else {
            rows = "No Existing " + type + ".";
        }

        $(href).html(rows);
    });
});

