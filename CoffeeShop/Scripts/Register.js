$(document).ready(function () {
    
    $("#register_submit").click(function (event) {
        var phoneNumber = $("#phone").val();
        alert(phoneNumber);
        var error_free = true;
        var re = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im;
        
        var isPhone = re.test(phoneNumber);
        alert(isPhone);
        if (!isPhone)
        {
            error_free = false;
        }
        if (!error_free) {
            event.preventDefault();
            alert('Please enter a valid phone number!');
        }
        else {
            alert('No errors: Form will be submitted');
        }
    });

});

