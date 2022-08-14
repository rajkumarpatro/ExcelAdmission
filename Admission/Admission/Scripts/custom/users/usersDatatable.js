
var userTable = function () {
    //TODO:: table-datatables-scroller.js use to fix scroller issue
    var table;
    var tableGrid = function () {
        table = $('#userTable');
        table.dataTable({
            autoWidth: false, 
            "ajax": {
                "url": GetUserList,
                "type": "GET",
                "datatype": "json",
                complete: function (data) {
                }
            },
            "columns": [
                { "title": "USER_NAME", "data": "USER_NAME" },
                { "title": "EMAIL_ID", "data": "EMAIL_ID" },
                { "title": "DESIGNATION_ID", "data": "DESIGNATION_ID" },
                { "title": "BRANCH_ID", "data": "BRANCH_ID" },
                { "title": "GENDER", "data": "GENDER" },
                {
                    "title": "DOB", "data": "DOB",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {

                        $(nTd).html(moment(oData.TOPIC_DATE).format("DD/MM/YYYY"));
                        //$(nTd).html(moment().diff(oData.DOB, 'years'));
                    }
                },
                { "title": "FATHER_NAME", "data": "FATHER_NAME" },
                { "title": "CONTACT1", "data": "CONTACT1" },
                {
                    "title": "ADDRESS", "data": "ADDRESS", "className": "width-10",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                        $(nTd).html("<div class='dt-longtext'>" + oData.ADDRESS + "</div>");
                    }
                },
                {
                    "title": "ISACTIVE", "data": "ISACTIVE",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                        $(nTd).html(oData.ISACTIVE ? "YES" : "NO");
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

    userTable.init();
});