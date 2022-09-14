$(document).ready(function () {
    $("#frmAdmission").validate({
        rules: {
            STUDENT_CONTACT: {
                validatePhone: "",
                minlength: 10,
                maxlength: 10
            },
            PARENT_CONTACT: {
                validatePhone: "",
                minlength: 10,
                maxlength: 10
            },
            APPEARING_YEAR: {
                validatePhone: "",
                minlength: 4,
                maxlength: 4
            },
            MARKS_10TH: {
                validatePhone: "",
                minlength: 2,
                maxlength: 2
            },
            MARKS_11TH: {
                validatePhone: "",
                minlength: 2,
                maxlength: 2
            },
            MARKS_12TH: {
                validatePhone: "",
                minlength: 2,
                maxlength: 2
            }
        }
    });
    $.validator.addMethod(
        "validatePhone",
        function (value, element) {
            debugger;
            var reg = new RegExp('^[0-9]*$');
            return reg.test(value)
        },
        "only numbers allowed"
    );

    //dd initialze
    $('.frmselect').select2({
        allowClear: true
    });

    //checkbox toggle initialize
    
    $('.chktoggle').bootstrapToggle();

    //date picker
    $(function () {
        init("#DOB");
        init("#DATE_OF_JOINING");
    });

   
});

function init(ele) {
    if ($(ele).val() === "") {
        var date = new Date().toLocaleDateString();
        $(ele).val(date);
    }

    $(ele).daterangepicker({
        locale: {
            format: 'DD/MM/YYYY'
        },
        singleDatePicker: true,
        showDropdowns: true,
    }, function (start, end, label) {
        var years = moment().diff(start, 'years');
    });
}