Dim NewLine As String
Dim counter As Integer
FileOpen(1, "Test", OpenMode.Input)
For counter = 1 To 3
NewLine = LineInput(1)
lstDisplay.Items.Add(NewLine)
'Opens the file for reading (input to RAM) referred to a 1 from now on
'This reads a line from the
'file and assigns it to
'variable NewLine
 Next
FileClose()
