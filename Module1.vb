Module Module1


    Sub Display_Array(ByRef ArrayData(,) As Integer)
        For i = 0 To 9
            For j = 0 To 9
                Console.Write(ArrayData(i, j) & "    ")
            Next
            Console.WriteLine()
        Next


    End Sub

    Sub Main()
        Dim rnd As New Random
        Dim ArrayData(9, 9) As Integer

        For i = 0 To 9
            For j = 0 To 9
                ArrayData(i, j) = rnd.Next(1, 101)


            Next

        Next
        Console.WriteLine("Array before sorting")
        Call Display_Array(ArrayData)

        Dim TempNumber As Integer
        Dim ArrayLength As Integer = 10
        For X = 0 To ArrayLength - 1
            For Y = 0 To ArrayLength - 2
                For Z = 0 To ArrayLength - Y - 2
                    If ArrayData(X, Z) > ArrayData(X, Z + 1) Then
                        TempNumber = ArrayData(X, Z)
                        ArrayData(X, Z) = ArrayData(X, Z + 1)
                        ArrayData(X, Z + 1) = TempNumber
                    End If
                Next
            Next
        Next

        Console.WriteLine("Array after sorting")
        Call Display_Array(ArrayData)
        Console.ReadKey()

    End Sub

End Module
