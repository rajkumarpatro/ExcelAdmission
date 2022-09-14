$(document).ready(function () {
    $('.chktoggle').bootstrapToggle();

    //form validation and submit for topic details
    $(document).on('click', '#btnAdd', function () {
        
        if ($("#frmSubject").valid()) {

            var fileData = new FormData(document.querySelector('#frmSubject'));
            fileData.set('ISACTIVE', $('#ISACTIVE').prop('checked'));

            $.ajax({
                url: AddSubject,
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
                    var courseId = $("#COURSE_ID").val();
                    subjectTable.destroy();
                    subjectTable.init(courseId);
                    $("#SUBJECT").val('');
                    $("#SUBJECT_ID").val('');
                    $("#ISACTIVE").bootstrapToggle(true ? 'on' : 'off');
                    $("#ONLINE_FEES").val('');

                    $("#btnAdd").text("Add Subject");
                    $("#btnCancel").hide();
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
    });

    //Deletes subject
    $(document).on('click', '.deleteSubject', function () {
        
        $.ajax({
            url: DeleteSubject +"?subjectId="+$(this).data('id'),
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
                var courseId = $("#COURSE_ID").val();
                subjectTable.destroy();
                subjectTable.init(courseId);
            },
            error: function (err) {
                $.unblockUI();
                notify("", "Something went wrong", "danger");

            },
            complete: function () {
                $.unblockUI();
                $("#SUBJECT").val('');
            }
        });

    });

    //gets the selected subject
    $(document).on('click', '.editSubject', function () {
        
        $.ajax({
            url: GetSubjectListById + "?subjectId=" + $(this).data('id'),
            type: "GET",
            beforeSend: function () {
                $.blockUI();
            },
            success: function (res) {
                debugger;
                $("#SUBJECT").val(res.SUBJECT);
                $("#SUBJECT_ID").val(res.SUBJECT_ID);
                $("#ISACTIVE").bootstrapToggle(res.ISACTIVE ? 'on': 'off');
                $("#ONLINE_FEES").val(res.ONLINE_FEES);

                $("#btnAdd").text("Update Subject");
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
        $("#btnAdd").text("Add Subject");
        $("#btnCancel").hide();
        document.getElementById("frmSubject").reset();
    });

    $(document).on('click', '#subjectTable tbody tr', function () {
        
    });
});
