$(document).ready(function () {
    
    $("#register_submit").click(function (event) {
        var phoneNumber = $("#phone").val();
        var error_free = true;
        var re = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im;
        var isPhone = re.test(phoneNumber);
        if (!isPhone)
        {
            error_free = false;
        }
        if (!error_free) {
            event.preventDefault();
            $("#phoneAlert").text('Please enter a valid phone number')
        }
    });

    $('input[type=password]').keyup(function () {
        var password = $(this).val();
        //check password length
        if (password.length < 8) {
            $('#length').removeClass('text-success').addClass('text-danger');
        } else {
            $('#length').removeClass('text-danger').addClass('text-success');
        }
        //check if password has at least one letter
        if (password.match(/[A-z]/)) {
            $('#letter').removeClass('text-danger').addClass('text-success');
        } else {
            $('#letter').removeClass('text-success').addClass('text-danger');
        }
        //check if password has a capital letter
        if (password.match(/[A-Z]/)) {
            $('#capital').removeClass('text-danger').addClass('text-success');
        } else {
            $('#capital').removeClass('text-success').addClass('text-danger');
        }
        //check if password has at least one number
        if (password.match(/\d/)) {
            $('#number').removeClass('text-danger').addClass('text-success');
        } else {
            $('#number').removeClass('text-success').addClass('text-danger');
        }
    }).focus(function () {
        $('#passwordInfo').show();
    }).blur(function () {
        $('#passwordInfo').hide();
    });

});

