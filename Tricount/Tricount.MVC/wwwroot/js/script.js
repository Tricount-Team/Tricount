document.getElementById("updateGroupModalButton").addEventListener("click", function () {
    var slug = window.location.pathname.split('/').pop();
    $.ajax({
        url: '/dashboard/getupdategroup/' + slug,
        type: 'GET',
        success: function (result) {
            $("#updateGroupModal").modal("show");
        },
        error: function () {
            alert("An error occurred while fetching modal content.");
        }
    });
});
document.getElementById("deleteGroupModalButton").addEventListener("click", function () {
    var slug = window.location.pathname.split('/').pop();
    $.ajax({
        url: '/dashboard/getdeletegroup/' + slug,
        type: 'GET',
        success: function (result) {
            $("#deleteGroupModal").modal("show");
        },
        error: function () {
            alert("An error occurred while fetching modal content.");
        }
    });
});
document.getElementById("createInviteModalButton").addEventListener("click", function () {
    var slug = window.location.pathname.split('/').pop();
    $.ajax({
        url: '/dashboard/getcreateinvite/' + slug,
        type: 'GET',
        success: function (result) {
            $("#createInviteModal").modal("show");
        },
        error: function () {
            alert("An error occurred while fetching modal content.");
        }
    });
});
document.getElementById("createExpenseModalButton").addEventListener("click", function () {
    var slug = window.location.pathname.split('/').pop();
    $.ajax({
        url: '/dashboard/getcreateexpense/' + slug,
        type: 'GET',
        success: function (result) {
            $("#createExpenseModal").modal("show");
        },
        error: function () {
            alert("An error occurred while fetching modal content.");
        }
    });
});