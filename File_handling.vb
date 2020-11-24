Public Class Form1

    Private lstDisplay As ListBox
    Private runbtn As Button
    Private Sub form_load()
        Me.runbtn = New Button()
        Me.runbtn.Location = New System.Drawing.Point(100, 100)


    End Sub


    Public Sub Filehanlde(path As String, mode As Integer)


        Dim NewLine As String   'creates a string(char array) called new line which is local to the program but global in the program
        Dim counter As Integer   'Creates a counter and leaves it empty (For Adv.Higher This saves 4bytes(32bit) on the stack for later assignment
        FileOpen(1, "Test", OpenMode.Input)   'opens a file and assigns a file descriptor as computer uses numbers to refer to files the file 'Opens the file for reading (input to RAM)                                         referred to a 1 from now on This reads a line from thefile and assigns it to variable NewLine
        For counter = 1 To 3                'runs a loop for 3 counter increments
            NewLine = LineInput(1)               'Reads newline from file 1 (*adv.higher using the sycall read and append null bytes for padding if lenght of file to long or short then joins                                                                     all up into one string*)
            lstDisplay.Items.Add(NewLine)         'displays the readline into  a list box
        Next                                   'increments the counter 
        FileClose()                             ' closes file to free resource

        'Not File that are open are opened as copies and only changed bytes are held in memory to be added or replace other bytes later


    End Sub

End Class
