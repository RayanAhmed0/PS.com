
var dataTable; // to be able to control the dataTable from the sweet alert and make ajax.reload()

$(document).ready(function () {

    loadDataTable();
})
function loadDataTable() {

    dataTable = $('#tableData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "15%" },
            { data: 'description', "width": "15%"  },
            { data: 'price', "width": "10%" },
            { data: 'category.name', "width": "15%" },
            
            {
                data: 'id', "render": function (data) {
                    return `         <div class="w-75 btn-group" role="group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-secondary mx-1">
        <i class="bi bi-pencil-square"></i> Edit
        </a>
        <a onClick=Delete("/admin/product/delete?id=${data}") class="btn btn-danger mx-1">
        <i class="bi bi-trash"></i> Delete
        </a>
        
        </div>`
                }, "width": "20%"
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