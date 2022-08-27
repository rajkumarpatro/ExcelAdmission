
var courseTable = function () {
    //TODO:: table-datatables-scroller.js use to fix scroller issue
    var table;
    var tableGrid = function () {
        table = $('#courseTable');
        table.dataTable({
            "ajax": {
                "url": GetCourseList,
                "type": "GET",
                "datatype": "json",
                complete: function (data) {
                }
            },
            "columns": [
                { "title": "COURSE", "data": "COURSE" },
                { "title": "OFFLINE_FEES", "data": "OFFLINE_FEES" },
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
                        $(nTd).html("<i data-id=" + oData.COURSE_ID + " class='feather icon-trash-2 deleteCourse'></i> <i data-id=" + oData.COURSE_ID + " class='feather icon-edit editCourse'></i>");
                    }
                }
            ]
        });
    }

    return {
        //main function to initiate the module
        init: function () {
            if (!jQuery().dataTable) {
                return;
            }

            tableGrid();
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
    courseTable.init();
});