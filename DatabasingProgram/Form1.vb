Public Class Form1
    Dim Output As String
    Dim selectedBox As String
    Dim Path As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Input.Click
        ListBox1.Items.Add(InputBox("Please enter text to be databased"))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        If My.Computer.FileSystem.FileExists(Path) Then
            My.Computer.FileSystem.DeleteFile(Path)
        End If
        ListBox1.Items.Clear()
    End Sub

    Private Sub Output1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Output1.Click

        If My.Computer.FileSystem.FileExists(Path) Then
            ListBox1.Items.Clear()
            Using MyReader As New Microsoft.VisualBasic.
            FileIO.TextFieldParser(
                        Path)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        ListBox1.Items.Add(currentField)
                    Next
                End While
            End Using

        Else

            MsgBox("Please insert data into Database first")

        End If

        



    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        Dim EditedText As String
        Dim selectedBoxNum As Integer
        selectedBoxNum = ListBox1.SelectedIndex
        selectedBox = ListBox1.Text
        If selectedBox = "" Then
            MsgBox("Please select data before you click edit")
            Output1_Click(sender, e)
        Else
            EditedText = InputBox("What would you like to change ''" & ListBox1.Items.Item(selectedBoxNum) & "'' to?")
            ListBox1.Items.RemoveAt(selectedBoxNum)
            ListBox1.Items.Insert(selectedBoxNum, EditedText)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Path = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\FlatFile.txt"
    End Sub

    Private Sub WriteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteBtn.Click

        If My.Computer.FileSystem.FileExists(Path) Then
            My.Computer.FileSystem.DeleteFile(Path)
        End If

        For counter = 0 To (ListBox1.Items.Count - 1)
            Output = ListBox1.Items.Item(counter)
            Dim fileWriter As System.IO.StreamWriter
            fileWriter = My.Computer.FileSystem.OpenTextFileWriter(Path, True)
            fileWriter.WriteLine(Output)
            fileWriter.Close()
        Next
    End Sub
End Class
