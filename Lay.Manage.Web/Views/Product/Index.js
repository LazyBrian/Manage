(function () {
    $(function () {

        var _productService = abp.services.app.product;

        $("#btnSubmit").click(function (e) {

            e.preventDefault;
            var data = {
                Url: $("#ProductUrl").val(),
                Type: $("#ProductType").select2('val')
            };
            // var _$modal = ("#product-modal");
            //abp.ui.setBusy(_$modal);
            _productService.addPro(data).done(function (data) {
                //_$modal.modal('hide');
                debugger;
                if (data.success) {
                    abp.message.success("添加成功", "产品");
                }
            }).always(function () {
                //abp.ui.clearBusy()
            });

        });

        $("#btnDelete").click(function (e) {
            e.preventDefault;
            
            var id = $(this).parent().parent().parent().find("#ProductId").val();
            var data = { Id: id };

            _productService.deleteEdition(data).done(function (data) {
                window.location.reload();
            });

        });
        function deleteProduct(Id) {

            var data = { Id: id };

            _productService.deleteEdition(data).done(function (data) {
                window.location.reload();
            });
        }
        
    });
})();