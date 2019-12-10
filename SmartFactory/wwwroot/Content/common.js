function check(a, c) {


    var a_check = a.split(",");
    // var b_check = b.split(",");

    var i = 0;
    for (var idx in a_check) {
        try {

            var check_it = $("#" + a_check[idx]).val();

            if (check_it == "") {
                //alert(b_check[i] + " is required.");
                $("#" + a_check[idx]).css("border", "solid 1px red");
                $("#" + a_check[idx]).focus();

                return;

            } else {
                $("#" + a_check[idx]).css("border", "solid 1px #e3e3e3");

            }


            i++;

        } catch(e) {
            return;
        }
    }

    $("#" + c).submit();

}

function addComma(n) {
    var reg = /(^[+-]?\d+)(\d{3})/;
    n += '';

    while (reg.test(n)) {
        n = n.replace(reg, '$1' + ',' + '$2');
    }

    return n;
}

function go(a) {
    location.href = a;

}

function searchlist() {


    //로딩바=====================================================================================================================================================
    $('<div id="loading" style="position: relative; top:50%; left:50%;z-index:20;"> <img src ="/images/common/ajax-loader_blue.gif" /></div>')
        .insertBefore('#result').ajaxStart(function() {
            $(this).show();

        }).ajaxStop(function() {
            $(this).hide();
        });
    //========================================================================================================================================================

    // 로딩바 끝===================================================================================================================================== 


    document.bbsform.submit();

    return false;
}

//function check_one(a,b){
//    var URL = "/ContractManageMent/aj2?doc_seq=" + b;   // ContractManageMent

//$.get(URL, function (data) {

//    $("#Result").html(data);
//});
//}


function del(url, idx) {


    if (confirm('Are you sure you want to delete it?')) {


        var url_full = url + "?idx=" + idx + "&mode_type=D";
        location.href = url_full;


    } else {
        return;
    }

}

function del_it(url) {


    if (confirm('Are you sure you want to delete it?')) {


        var url_full = url + "&mode_type=D";

        location.href = url_full;


    } else {
        return;
    }

}

function del_imsi(url) {


    if (confirm('Are you sure you want to delete it?')) {


        var url_full = url + "&mode_type=E";

        location.href = url_full;


    } else {
        return;
    }

}


function go_set(url, pp) {

    var url_v = $("#" + pp + " option:selected").val();
    var _target = url + "?" + pp + "=" + url_v;

    location.href = _target;
}


// 숫자만 입력================================================================
$(".numOnly").css({ "ime-mode": "disabled" }); // 소수점 가능


$(".telOnly").css({ "ime-mode": "disabled" }); // 숫자


$('.telOnly').keyup(function (event) {
    $(this).val($(this).val().replace(/[^0-9]/g, ''));
});


$('.telOnly').keypress(function (event) {


    if (event.which && (event.which > 47 && event.which < 58 || event.which == 8)) {
    } else {


        event.preventDefault();
    }
});

$('.numOnly').keypress(function (event) {


    if (event.which && (event.which > 47 && event.which < 58 || event.which == 8 || event.which == 46)) {

    } else {


        event.preventDefault();
    }
});