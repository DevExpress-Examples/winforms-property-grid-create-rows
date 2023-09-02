Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid.Rows

Namespace AddRowsRuntime

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            CreateRows()
            Dim person As Person = New Person()
            person.LastName = "Doe"
            person.FirstName = "John"
            propertyGridControl1.SelectedObject = person
        End Sub

        Private Sub CreateRows()
            Dim rowLastName As EditorRow = New EditorRow("LastName")
            rowLastName.Properties.Caption = "Last name"
            propertyGridControl1.Rows.Add(rowLastName)
            Dim rowCategory As CategoryRow = New CategoryRow("Address")
            propertyGridControl1.Rows.Add(rowCategory)
            Dim rowAddressLine1 As EditorRow = New EditorRow("AddressLine1")
            rowAddressLine1.Properties.Caption = "Address Line 1"
            rowCategory.ChildRows.Add(rowAddressLine1)
            Dim rowZip As EditorRow = New EditorRow("Zip")
            rowZip.Properties.Caption = "Zip Code"
            rowCategory.ChildRows.Add(rowZip)
        End Sub
    End Class

    Public Class Person

        Private _FirstName As String

        Public Property FirstName As String
            Get
                Return _FirstName
            End Get

            Set(ByVal value As String)
                _FirstName = value
            End Set
        End Property

        Private _LastName As String

        Public Property LastName As String
            Get
                Return _LastName
            End Get

            Set(ByVal value As String)
                _LastName = value
            End Set
        End Property

        Private _AddressLine1 As String

        Public Property AddressLine1 As String
            Get
                Return _AddressLine1
            End Get

            Set(ByVal value As String)
                _AddressLine1 = value
            End Set
        End Property

        Private _Zip As String

        Public Property Zip As String
            Get
                Return _Zip
            End Get

            Set(ByVal value As String)
                _Zip = value
            End Set
        End Property
    End Class
End Namespace
