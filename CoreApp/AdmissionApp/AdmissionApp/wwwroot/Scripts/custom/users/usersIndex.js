$(document).ready(function () {
    //Delete user
    $(document).on('click', '.deleteUser', function () {
        $.ajax({
            url: DeleteUser + "?userId=" + $(this).data('id'),
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
    $(document).on('click', '.editUser', function () {
        openUserView($(this).data('id'))
    });

    //Opens users view
    $(document).on('click', '#btnAddUser', function () {
        openUserView()
    });

    function openUserView(userId)
    {
        $.ajax({
            url: AddUser + "?userId=" + userId,
            type: "GET",
            beforeSend: function () {
                $.blockUI();
            },
            success: function (res) {
                $("#divUserList").hide();
                $("#divUserForm").show();
                $("#divUserForm").html(res);
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

    //save User
    $(document).on('click', '#btnSaveUser', function () {
        var isvalid = $("#frmCourse").valid();

        if (isvalid) {
            var frmdata = new FormData(document.querySelector('#frmCourse'));
            frmdata.set('GENDER', $('#GENDER').prop('checked'));
            frmdata.set('ISACTIVE', $('#ISACTIVE').prop('checked'));

            var fileUpload = $("#fileupload").get(0);
            var files = fileUpload.files;
            if (files.length > 0)
                frmdata.append(files[0].name, files[0]);

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
                   
                    if (res === 'False')
                        notify("", "Something went wrong", "danger");
                    else {
                        notify("", "Data Add / Edited Successfully", "success");
                    }
                    userTable.reloadTable();

                    $.unblockUI();

                    $("#divUserList").show();
                    $("#divUserForm").empty();
                    $("#divUserForm").hide();
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

    $(document).on('keyup', '#EMAIL_ID', function () {
        $('#spanemail').text($(this).val());
    });

    $(document).on('keyup', '#USER_NAME', function () {
        $('#spanname').text($(this).val());
    });
});
