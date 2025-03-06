Imports DevExpress.XtraEditors

Module ModUtils
    Sub requiredMessage(ByVal fields As String)
        XtraMessageBox.Show("Required Fields: " + vbNewLine + fields, APPNAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Sub successCreateMessage(ByVal action As String)
        XtraMessageBox.Show(action & " Successfully! Please refresh the page", APPNAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Function validateField(ByRef control As DateEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function

    Function validateField(ByRef control As TextEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function

    Function validateField(ByRef control As LookUpEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function

    Function validateField(ByRef control As ComboBoxEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function

    Function validateField(ByRef control As SpinEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function
End Module
