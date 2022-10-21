Imports System.IO
Module Module1

    Function Enqueue(ByRef QueueData() As String, ByRef Add_item As String, ByRef End_Pointer As Integer) As Boolean
        If End_Pointer = 20 Then
            Return False
        Else
            QueueData(End_Pointer) = Add_item
            End_Pointer = End_Pointer + 1
            Return True
        End If
    End Function


    Function ReadFile(ByRef QueueData() As String, ByRef End_Pointer As Integer) As Integer
        Dim File_Name, File_data As String
        Console.Write("Enter File name ")
        File_Name = Console.ReadLine

        If File.Exists(File_Name) Then
            Dim file_reader As StreamReader
            file_reader = File.OpenText(File_Name)
            Dim Status As Boolean = True

            While file_reader.Peek <> -1 And Status = True
                File_data = file_reader.ReadLine
                Status = Enqueue(QueueData, File_data, End_Pointer)

            End While
            If Status = True Then
                file_reader.Close()
                Return 2
            Else
                file_reader.Close()
                Return 1
            End If

        Else
            Return -1
        End If


    End Function
    Sub Main()
        Dim QueueData(0 To 19) As String
        Dim Start_pointer As Integer = 0
        Dim End_Pointer As Integer = 0
        Dim Return_value As Integer
        Return_value = ReadFile(QueueData, End_Pointer)
        If Return_value = -1 Then
            Console.WriteLine("File not found ")
        Else
            If Return_value = 1 Then
                Console.WriteLine("Queue is full")
            Else
                Console.WriteLine("Data added successfully ")
            End If
        End If




        Console.ReadKey()


    End Sub

End Module