<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T137443)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# XAF WinForms - Add an Unbound Control (Button) to the Form Layout in an XAF View (with a Fully Custom ViewItem)

This example adds a custom control to a Detail View. See the following help topic for more information: [How to Add an Unbound Control (Button) to the Form Layout in an XAF View (with a Fully Custom ViewItem)](https://docs.devexpress.com/eXpressAppFramework/113653/ui-construction/view-items-and-property-editors/how-to-add-a-button-to-a-detail-view-using-custom-view-item).

![custom-button-in-form](https://github.com/user-attachments/assets/9f66a6f3-5471-4ad4-bbd3-8e098f16591e)

## Implementation Considerations

This is an advanced customization method that requires coding. Use it when you want to add an existing or custom control to the client area of a Detail View or Dashboard View. This approach allows you to obtain data from the current View object if necessary. Your control can be unbound or can load data from external sources.

If you want to bind a control to a business class property and add that control to both List View and Detail View, then consider the [custom Property Editor approach](https://docs.devexpress.com/eXpressAppFramework/113097/ui-construction/view-items-and-property-editors/property-editors#custom-property-editors).

This approach does not impose any restrictions on UI Control and XAF View interaction. You can implement custom logic in a `ViewController` or a custom UI control. [ViewItem](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.ViewItem) descendants may implement their own inner logic.

If you want to display standard [XAF Actions](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions) in a Detail View, use the technique described in the following topic: [How to: Include an Action to a Detail View Layout](https://docs.devexpress.com/eXpressAppFramework/112816/ui-construction/view-items-and-property-editors/how-to-include-an-action-to-a-detail-view-layout).

## Files to Review
* [ButtonDetailViewItemWin.cs](CS/EFCore/ButtonInFormEF/ButtonInFormEF.Win/ButtonDetailViewItemWin.cs) 
* [Model.xafml](CS/EFCore/ButtonInFormEF/ButtonInFormEF.Win/Model.xafml) 

## Documentation
* [How to Add an Unbound Control (Button) to the Form Layout in an XAF View (with a Built-in ActionContainerViewItem)](https://docs.devexpress.com/eXpressAppFramework/112816/ui-construction/view-items-and-property-editors/include-an-action-to-a-detail-view-layout)
* [How to Add an Unbound Control (Button) to the Form Layout in an XAF View (with a Built-in ControlViewItem)](https://docs.devexpress.com/eXpressAppFramework/113652/ui-construction/view-items-and-property-editors/how-to-create-a-custom-control-detail-item)
* [How to: Include a Custom UI Control That Is Not Integrated by Default (WinForms, ASP.NET Web Forms, and ASP.NET Core Blazor)](https://docs.devexpress.com/eXpressAppFramework/113610/ui-construction/using-a-custom-control-that-is-not-integrated-by-default/using-a-custom-control-that-is-not-integrated-by-default)

## More Examples
* [How to: Use a Custom View Item to Add a Button to a Detail View (Blazor)](https://github.com/DevExpress-Examples/xaf-custom-view-item-blazor)
* [XAF - Add a Custom Button to a Form (ASP.NET WebForms)](https://github.com/DevExpress-Examples/XAF_how-to-add-a-button-to-a-form-using-custom-view-item-t137443/tree/17.2.3+)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_how-to-add-a-button-to-a-form-using-custom-view-item-t137443&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_how-to-add-a-button-to-a-form-using-custom-view-item-t137443&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
