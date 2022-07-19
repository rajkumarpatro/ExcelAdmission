$(document).ready(function () {
    $('.chktoggle').bootstrapToggle();

    //form validation and submit for topic details
    $(document).on('click', '#btnAdd', function () {
        
        if ($("#frmCourse").valid()) {

            var fileData = new FormData(document.querySelector('#frmCourse'));
            fileData.set('ISACTIVE', $('#ISACTIVE').prop('checked'));

            $.ajax({
                url: AddCourse,
                type: "POST",
                contentType: false,
                processData: false,
                data: fileData,
                beforeSend: function () {
                    $.blockUI();
                },
                success: function (res) {

                    if (res === 'False')
                        notify("", "Something went wrong", "danger");
                    else {
                        notify("", "Data Add / Edited Successfully", "success");
                    }
                    courseTable.destroy();
                    courseTable.init();

                },
                error: function (err) {
                    $.unblockUI();
                    notify("", "Something went wrong", "danger");

                },
                complete: function () {
                    $.unblockUI();
                    document.getElementById("frmCourse").reset();
                }
            });
        }
    });

    //Deletes course
    $(document).on('click', '.deleteCourse', function () {
        
        $.ajax({
            url: DeleteCourse +"?courseId="+$(this).data('id'),
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
                courseTable.destroy();
                courseTable.init();
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

    //gets the selected course
    $(document).on('click', '.editCourse', function () {
        
        $.ajax({
            url: GetCourseListById + "?courseId=" + $(this).data('id'),
            type: "GET",
            beforeSend: function () {
                $.blockUI();
            },
            success: function (res) {
                $("#COURSE").val(res.COURSE);
                $("#COURSE_ID").val(res.COURSE_ID);
                $("#ISACTIVE").bootstrapToggle(res.ISACTIVE ? 'on': 'off');
                $("#OFFLINE_FEES").val(res.OFFLINE_FEES);
                $("#ONLINE_FEES").val(res.ONLINE_FEES);

                $("#btnAdd").text("Update Course");
                $("#btnCancel").show();
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

    $(document).on('click', '#btnCancel', function () {
        $("#btnAdd").text("Add Course");
        $("#btnCancel").hide();
        document.getElementById("frmCourse").reset();
    });

    $(document).on('click', '#courseTable tbody tr', function () {
        
    });
});
