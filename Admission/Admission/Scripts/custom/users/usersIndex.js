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
});
