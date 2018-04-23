using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Mobile.MobileModel;
using DevExpress.ExpressApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySolution.Module.Mobile {
    public interface IModelButtonDetailViewItemMobile : IModelViewItem { }
    public class SimpleButton : TitledComponent {
        public SimpleButton() {
            Type = "simpleButton";
        }
    }
    [ViewItem(typeof(IModelButtonDetailViewItemMobile))]
    public class ButtonDetailViewItemMobile : ViewItem {
        protected override object CreateControlCore() {
            SimpleButton simpleButton = new SimpleButton();
            simpleButton["text"] = "Click me!";
            return simpleButton;
        }
        public ButtonDetailViewItemMobile(IModelViewItem model, Type objectType) : base(objectType, model.Id) { }
    }
}
