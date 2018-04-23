var componentInfo = {
    componentViewModel: (viewModel) => {
        var result = $.extend({}, viewModel);
        result.text = viewModel.text;
        result.type = "normal";
        result.onClick = function (e) {
            DevExpress.ui.notify("Action from custom view item was executed!");
        };
        return result;
    },
    defaults: {
        style: { /*width: "auto", height: "auto"*/ }
    }
};

DevExpress.ExpressApp.Mobile.updateComponentInfo("simpleButton", componentInfo);