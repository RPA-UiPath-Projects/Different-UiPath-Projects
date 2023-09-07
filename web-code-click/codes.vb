Imports UiPath.Core.Activities
Public Sub ClickUiElement(uiElement As UiElement, timeout As Integer)
    Try
        If uiElement.WaitForReady(timeout) = True Then
            uiElement.Click()
        Else
            Throw New Exception("UiElement not found")
        End If
    Catch ex As Exception
        Throw New Exception("Error clicking UiElement: " + ex.Message)
    End Try
End Sub