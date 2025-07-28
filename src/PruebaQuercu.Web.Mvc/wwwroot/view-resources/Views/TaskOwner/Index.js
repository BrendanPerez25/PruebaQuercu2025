(function ($) {
    $(function () {
        $('#TaskOwnerTable').DataTable({
            paging: true,
            searching: true,
            ordering: true,
            language: {
                url: '//cdn.datatables.net/plug-ins/1.13.6/i18n/es-ES.json'
            }
        });
    });
})(jQuery);