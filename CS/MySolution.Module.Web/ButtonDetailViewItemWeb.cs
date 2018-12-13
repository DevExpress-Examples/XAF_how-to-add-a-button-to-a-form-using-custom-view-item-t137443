using System;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web;
using DevExpress.Web;

namespace MySolution.Module.Web {
    public interface IModelButtonDetailViewItemWeb : IModelViewItem { }

    [ViewItemAttribute(typeof(IModelButtonDetailViewItemWeb))]
    public class ButtonDetailViewItemWeb : ViewItem {
        public ButtonDetailViewItemWeb(IModelViewItem model, Type objectType) : base(objectType, model.Id) { }
        protected override object CreateControlCore() {
            ASPxButton button = new ASPxButton();
            button.Text = "Click me!";
            button.EnableClientSideAPI = true;
            button.Click += new EventHandler(button_Click);
            return button;
        }
        void button_Click(object sender, EventArgs e) {
            WebWindow.CurrentRequestWindow.RegisterClientScript("ShowAlert", @"alert('Action from custom view item was executed!');");
        }
    }
}

