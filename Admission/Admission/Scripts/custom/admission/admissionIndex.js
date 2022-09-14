$(document).ready(function () {
   

    //Delete user
    $(document).on('click', '.deleteAdmission', function () {
        $.ajax({
            url: DeleteAdmission + "?admissionId=" + $(this).data('id'),
            type: "GET",
            beforeSend: function () {
                $.blockUI();
            },
            success: function (res) {
                if (res === 'False')
                    notify("", "Something went wrong", "danger");
                else {
                    notify("", "Data Add / Edited Successfully", "success");
                }
                userTable.reloadTable();

                $.unblockUI();
            },
            error: function (err) {
                $.unblockUI();
                notify("", "Something went wrong", "danger");

            },
            complete: function () {
                $.unblockUI();
            }
        });
    });

    //Opens users view to edit
    $(document).on('click', '.editAdmission', function () {
        openAdmissionView($(this).data('id'))
    });

    //Opens users view
    $(document).on('click', '#btnAddAdmission', function () {
        openAdmissionView()
    });

    function openAdmissionView(admissionId)
    {
        $.ajax({
            url: AddAdmission + "?admissionId=" + admissionId,
            type: "GET",
            beforeSend: function () {
                $.blockUI();
            },
            success: function (res) {
                $("#divAdmissionList").hide();
                $("#divAdmissionForm").show();
                $("#divAdmissionForm").html(res);
            },
            error: function (err) {
                $.unblockUI();
                notify("", "Something went wrong", "danger");

            },
            complete: function () {
                $.unblockUI();
            }
        });
    }

    //save Admission
    $(document).on('click', '#btnSaveAdmission', function () {
        var isvalid = $("#frmAdmission").valid();
        debugger;
        if (isvalid) {
            var frmdata = new FormData(document.querySelector('#frmAdmission'));
            frmdata.set('MEDIUM', $('#MEDIUM').prop('checked'));
            frmdata.set('CAME_THROUGH_ID', $('.reference .form-check-input:checked').data('val'));
            
            var fileUpload = $("#fileupload").get(0);
            var files = fileUpload.files;
            if (files.length > 0)
                frmdata.append(files[0].name, files[0]);

            $.ajax({
                url: AddAdmission,
                type: 'POST',
                data: frmdata,
                contentType: false,
                processData: false,
                beforeSend: function () {
                    $.blockUI();
                },
                success: function (res) {
                   
                    if (res === 'False')
                        notify("", "Something went wrong", "danger");
                    else {
                        notify("", "Data Add / Edited Successfully", "success");
                    }
                    admissionTable.reloadTable();

                    $.unblockUI();

                    $("#divAdmissionList").show();
                    $("#divAdmissionForm").empty();
                    $("#divAdmissionForm").hide();
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

    //profile img click
    $(document).on('click', '#profileimg', function () {
        $("#fileupload").trigger('click');
    });

    $(document).on('change', '#fileupload', function () {
        
        var selectedFile = $(this).get(0).files[0];
        var reader = new FileReader();

        var imgtag = document.getElementById("profileimg");
        imgtag.title = selectedFile.name;

        reader.onload = function (event) {
            imgtag.src = event.target.result;
        };

        reader.readAsDataURL(selectedFile);
    });

    $(document).on('keyup', '#STUDENT_EMAIL', function () {
        $('#spanemail').text($(this).val());
    });

    $(document).on('keyup', '#STUDENT_NAME', function () {
        $('#spanname').text($(this).val());
    });

    $(document).on('click', '.reference .form-check-input', function () {
        $('.reference .form-check-input').prop('checked', false)
        $(this).prop('checked', true)
    });
});
