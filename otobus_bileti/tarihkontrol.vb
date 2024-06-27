Public Class tarihkontrol
    Public Shared Sub tarihkontrolet(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is DateTimePicker Then
                Dim dtPicker As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                dtPicker.MinDate = DateTime.Today
            ElseIf ctrl.HasChildren Then
                tarihkontrolet(ctrl)
            End If
        Next
    End Sub
End Class
