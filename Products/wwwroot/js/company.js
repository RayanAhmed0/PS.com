
var dataTable; // to be able to control the dataTable from the sweet alert and make ajax.reload()

$(document).ready(function () {

    loadDataTable();
})
function loadDataTable() {

    dataTable = $('#tableData').DataTable({
        "ajax": { url: '/admin/company/getall' },
        "columns": [
            { data: 'name', "width": "13%" }, // we have to make it camel case as the api is returning the fields like this 
            { data: 'phonenumber', "width": "13%" },
            { data: 'city', "width": "13%" },
            { data: 'state', "width": "13%" },
            { data: 'streetAddress', "width": "13%" },
            { data: 'postalCode', "width": "13%" },
            {
                data: 'id', "render": function (data) {
                    return `         <div class="w-75 btn-group" role="group">
                    <a href="/admin/company/upsert?id=${data}" class="btn btn-secondary mx-1">
        <i class="bi bi-pencil-square"></i> Edit
        </a>
        <a onClick=Delete("/admin/company/delete?id=${data}") class="btn btn-danger mx-1">
        <i class="bi bi-trash"></i> Delete
        </a>
        
        </div>`
                }, "width": "13%"
            },


        ]
    });
}
function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#d33",
        cancelButtonColor: "#3085d6",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload()
                    toastr.succes(data.message)

                }
            })
        }
    });
}