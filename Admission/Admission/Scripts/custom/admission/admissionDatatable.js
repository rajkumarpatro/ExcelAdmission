
var admissionTable = function () {
    //TODO:: table-datatables-scroller.js use to fix scroller issue
    var table;
    var tableGrid = function () {
        table = $('#admissionTable');
        table.dataTable({
            autoWidth: false, 
            "ajax": {
                "url": GetAdmissionList,
                "type": "GET",
                "datatype": "json",
                complete: function (data) {
                }
            },
            "columns": [
                { "title": "TRANSACTION_ID", "data": "TRANSACTION_ID" },
                { "title": "Name", "data": "STUDENT_NAME" },
                {
                    "title": "DOJ", "data": "DATE_OF_JOINING",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {

                        $(nTd).html(moment(oData.TOPIC_DATE).format("DD/MM/YYYY"));
                        //$(nTd).html(moment().diff(oData.DOB, 'years'));
                    }
                },
                { "title": "Email", "data": "STUDENT_EMAIL" },
                {
                    "title": "Address", "data": "PERMANENT_ADDRESS",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                        $(nTd).html("<div class='dt-longtext'>" + oData.PERMANENT_ADDRESS + "</div>");
                    }
                },
                { "title": "Contact", "data": "STUDENT_CONTACT" },
                { "title": "PARENT CONTACT", "data": "PARENT_CONTACT" },
                { "title": "Fees", "data": "TOTAL_FEES" },
                { "title": "PART PAYMENT", "data": "PART_PAYMENT" },
                { "title": "FEES STATUS", "data": "FEES_PAID" },
                { "title": "FEE DATE", "data": "PAYMENT_DATE" },
                {
                    "title": "ISACTIVE", "data": "ISACTIVE",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                        $(nTd).html(oData.ISACTIVE ? "YES" : "NO");
                    }
                },
                {
                    "title": "EDIT", "data": "ISACTIVE",
                    fnCreatedCell: function (nTd, sData, oData, iRow, iCol) {
                        $(nTd).html("<i style='color: blue; cursor: pointer' data-id=" + oData.A_ID + " class='feather icon-trash-2 deleteAdmission'></i> | <i style='cursor: pointer;color: blue;' data-id=" + oData.A_ID + " class='feather icon-edit editAdmission'></i>");
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
            table.DataTable().ajax.reload(null, false); // admission paging is not reset on reload
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

    admissionTable.init();
});