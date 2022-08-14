$(document).ready(function () {


    //Opens users view
    $(document).on('click', '#btnAddUser', function () {

        $.ajax({
            url: AddUser,
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

    });
});
