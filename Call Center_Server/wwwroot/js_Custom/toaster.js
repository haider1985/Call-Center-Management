window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, { timeOut: 5000 })
    }

    if (type === "error") {
        toastr.error(message, { timeOut: 5000 })
    }
}