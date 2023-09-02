<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638571/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2098)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Property Grid - Create editor and category rows

This example demonstrates how to create editor and category rows and add them to the [PropertyGrid](https://docs.devexpress.com/WindowsForms/119885/controls-and-libraries/property-grid) control:

```csharp
void CreateRows() {
    EditorRow rowLastName = new EditorRow("LastName");
    rowLastName.Properties.Caption = "Last name";
    propertyGridControl1.Rows.Add(rowLastName);
    CategoryRow rowCategory = new CategoryRow("Address");
    propertyGridControl1.Rows.Add(rowCategory);
    EditorRow rowAddressLine1 = new EditorRow("AddressLine1");
    rowAddressLine1.Properties.Caption = "Address Line 1";
    rowCategory.ChildRows.Add(rowAddressLine1);
    EditorRow rowZip = new EditorRow("Zip");
    rowZip.Properties.Caption = "Zip Code";
    rowCategory.ChildRows.Add(rowZip);
}
```


## Files to Review

* [Form1.cs](./CS/AddRowsRuntime/Form1.cs) (VB: [Form1.vb](./VB/AddRowsRuntime/Form1.vb))


## Documentation

* [Property Grid Rows](https://docs.devexpress.com/WindowsForms/401851/controls-and-libraries/property-grid/rows#add-individual-rows)
