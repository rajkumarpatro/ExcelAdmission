$(document).ready(function () {
    $("#frmCourse").validate({
        rules: {
            CONTACT1: {
                validatePhone: "",  
                minlength: 10,
                maxlength: 10
            },
            CONTACT2: {
                validatePhone: "",  
                minlength: 10,
                maxlength: 10
            },
            BRANCH_ID: {
                required: {
                    depends: function (element) {
                        
                        return true;
                    }
                }
            },

            DESIGNATION_ID: {
                required: {
                    depends: function (element) {
                        
                        return true;
                    }

                }
            }
        }
    });
    $.validator.addMethod(
        "validatePhone",
        function (value, element) {
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

        if ($('#DOB').val() === "") {
            var date = new Date().toLocaleDateString();
            $('#DOB').val(date);
        }

        $('input[id="DOB"]').daterangepicker({
            locale: {
                format: 'DD/MM/YYYY'
            },
            singleDatePicker: true,
            showDropdowns: true,
        }, function (start, end, label) {
            var years = moment().diff(start, 'years');
        });
    });

    //save User
    $(document).on('click', '#btnSaveUser', function () {
        var isvalid = $("#frmCourse").valid();

        

        if (isvalid) {
            
            var frmdata = new FormData(document.querySelector('#frmCourse'));
            frmdata.set('GENDER', $('#GENDER').prop('checked'));
            frmdata.set('ISACTIVE', $('#ISACTIVE').prop('checked'));

            $.ajax({
                url: AddUser,
                type: 'POST',
                data: frmdata,
                contentType: false,
                processData: false,
                beforeSend: function () {
                    $.blockUI();
                },
                success: function (res) {
                    debugger;
                    if (res === 'False')
                        notify("", "Something went wrong", "danger");
                    else {
                        notify("", "Data Add / Edited Successfully", "success");
                    }
                    $.unblockUI();
                },
                error: function (err) {
                    $.unblockUI();
                    notify("", "Something went wrong", "danger");

                },
                complete: function () {
                    $.unblockUI();
                }
            })
        }
    });
});
