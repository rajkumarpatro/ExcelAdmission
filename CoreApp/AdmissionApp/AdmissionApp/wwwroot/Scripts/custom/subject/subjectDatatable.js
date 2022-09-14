
var subjectTable = function () {
    //TODO:: table-datatables-scroller.js use to fix scroller issue
    var table;
    var tableGrid = function (courseId) {
        table = $('#subjectTable');
        //alert(courseId);
        table.dataTable({
            "ajax": {
                "url": GetSubjectList,
                "type": "GET",
                "datatype": "json",
                "data": { courseId: courseId },
                complete: function (data) {
                }
            },
            "columns": [
                { "title": "SUBJECT", "data": "SUBJECT" },
                { "title": "ONLINE_FEES", "data": "ONLINE_FEES" },
                {
                    "title": "ISACTIVE", "data": "ISACTIVE",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                        $(nTd).html(oData.ISACTIVE ? "YES":"NO");
                    }
                },
                {
                    "title": "EDIT", "data": "ISACTIVE",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                        $(nTd).html("<i data-id=" + oData.SUBJECT_ID + " class='feather icon-trash-2 deleteSubject'></i> <i data-id=" + oData.SUBJECT_ID + " class='feather icon-edit editSubject'></i>");
                    }
                }
            ]
        });
    }

    return {
        //main function to initiate the module
        init: function (courseId) {
            if (!jQuery().dataTable) {
                return;
            }

            tableGrid(courseId);
        },
        reloadTable: function () {
            table.DataTable().ajax.reload(null, false); // user paging is not reset on reload
        },
        destroy: function () {
            if (table != null)
                table.DataTable().destroy();
        },
        clear: function () {
            if (table != null)
                table.DataTable().clear();
        },
        draw: function () {
            if (table != null)
                table.DataTable().draw();
        }
    };
}();

jQuery(document).ready(function () {

    document.title = "Subject";

    $(document).on('change', '#COURSE_ID', function () {
        debugger;
        var courseId = $(this).val();
        subjectTable.destroy();
        subjectTable.init(courseId);
        //alert('hi');
    });

});