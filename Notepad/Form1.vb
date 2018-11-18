Public Class Form1

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Space Then
            Dim selectionleghth As Integer = RichTextBox1.SelectionLength
            Dim selectionstart As Integer = RichTextBox1.SelectionStart
            Dim letter As String = String.Empty
            Do Until letter = " " Or RichTextBox1.SelectionStart = 0
                RichTextBox1.SelectionStart -= 1
                RichTextBox1.SelectionLength += 1
                letter = RichTextBox1.Text.Substring(RichTextBox1.SelectionStart, 1)
            Loop

            If RichTextBox1.SelectedText = "hello" Or RichTextBox1.SelectedText = "hello" Then
                RichTextBox1.SelectionColor = Color.Blue
            Else
                ' do nothing
            End If
            RichTextBox1.SelectionStart = selectionstart
            RichTextBox1.SelectionLength = 0
            RichTextBox1.SelectionColor = Color.Black
        End If
    End Sub


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim newform = New Form1
        newform.Text = "Untitiled-Notepad"
        newform.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFileDialog1.Filter = "Text Files|.*txt"
        OpenFileDialog1.Title = "Open Text File"
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

        End If
        Me.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        SaveFileDialog1.Filter = "Text File|.*txt"
        SaveFileDialog1.Title = "Save as Text File"
        System.IO.File.Create(SaveFileDialog1.FileName).Dispose()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimeToolStripMenuItem.Click
        RichTextBox1.Text = Date.Now
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub
End Class


