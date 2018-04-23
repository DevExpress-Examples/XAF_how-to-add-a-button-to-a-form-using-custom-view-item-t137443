using System;
using System.Windows.Forms;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp;

namespace MySolution.Module.Win {
    public interface IModelButtonDetailViewItemWin : IModelViewItem { }

    [ViewItemAttribute(typeof(IModelButtonDetailViewItemWin))]
    public class ButtonDetailViewItemWin : ViewItem {
        public ButtonDetailViewItemWin(IModelViewItem model, Type objectType)
            : base(objectType, model.Id) {
            CreateControl();
        }
        protected override object CreateControlCore() {
            Button button = new Button();
            button.Text = "Click me!";
            button.Click += new EventHandler(button_Click);
            return button;
        }
        void button_Click(object sender, EventArgs e) {
            throw new UserFriendlyException("Action from custom view item was executed!");
        }
    }
}