Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Controls

Namespace TaskPane

    ''' <summary>
    ''' Extension methods for <see cref="WpfTaskPane"/>.
    ''' </summary>
    <ComVisible(False)>
    Public Module TaskPaneExtensions

        ''' <summary>
        ''' Show the current user control in the task pane.
        ''' </summary>
        ''' <param name="userControl">The <see cref="UserControl"/> to show in the task pane.</param>
        ''' <param name="title">The title to use in the task pane.</param>
        ''' <returns></returns>
        <Extension>
        Public Function ShowInTaskPane(ByVal userControl As UserControl, ByVal title As String) As WpfTaskPane

            'Create and return the WpfTaskPane
            Return New WpfTaskPane(title:=title) With {.Visible = True, .UserControl = userControl}
        End Function

    End Module

End Namespace
