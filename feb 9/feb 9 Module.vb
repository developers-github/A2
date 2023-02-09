Module Module1
    MustInherit Class LESCO
        Function fun1(ByRef NewUnits As Integer) As Integer
            Dim cost As Integer
            cost = NewUnits * 20
            Return cost
        End Function
        Function fun2(ByRef NewUnits As Integer) As Integer
            Dim cost As Integer
            cost = NewUnits * 50
            Return cost
        End Function
    End Class
    Class A : Inherits LESCO
        Function fun3(ByRef NewUnits As Integer) As Integer
            Dim cost As Integer
            cost = NewUnits * 150
            Return cost
        End Function
    End Class
    Class B : Inherits A
        Function fun4(ByRef NewUnits As Integer) As Integer
            Dim cost As Integer
            cost = NewUnits * 200
            Return cost
        End Function
    End Class
    Sub Main()
        Dim obj As New LESCO
        Dim units, bill, return_cost As Integer
        Console.Write("Enter Units ")
        units = Console.ReadLine
        If units <= 300 Then
            return_cost = obj.fun1(units)
            If units <= 500 Then
                return_cost = obj.fun2(units)
            Else
                If units <= 900 Then
                    return_cost = obj.fun3(units)
                Else
                    return_cost = obj.fun4(units)
                End If
            End If
        End If

        bill = return_cost + 1000
        If bill > 5000 Then
            bill = bill + (bill * 15 / 100)
        End If
        Console.WriteLine("Payable Bill " & bill)
        Console.ReadKey()
    End Sub
End Module
