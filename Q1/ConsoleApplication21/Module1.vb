Module Module1


    Structure node
        Dim data As Integer
        Dim nextnode As Integer
    End Structure
    Sub outputNodes(ByRef linkedlist() As node, ByRef StartPointer As Integer)
        Dim current As Integer
        current = StartPointer

        While current <> -1
            Console.WriteLine(current & " " & linkedlist(current).data & " " & linkedlist(current).nextnode)
            current = linkedlist(current).nextnode
        End While
    End Sub

    Function addNode(ByRef linkedList() As node, ByRef StartPointer As Integer, ByRef emptyList As Integer) As Boolean
        Console.WriteLine("Enter the data to add")
        Dim dataToAdd As Integer = Console.ReadLine()
        Dim previousPointer As Integer = 0
        Dim currentPointer As Integer = StartPointer
        Dim newNode As node
        If emptyList < 0 Or emptyList > 9 Then
            Return False
        Else
            newNode.data = dataToAdd
            newNode.nextNode = -1
            linkedList(emptyList) = newNode
            previousPointer = 0
            While (currentPointer <> -1)
                previousPointer = currentPointer
                currentPointer = linkedList(currentPointer).nextNode
            End While
            Dim valueToWrite As Integer = emptyList
            linkedList(previousPointer).nextNode = valueToWrite
            emptyList = linkedList(emptyList).nextNode
            Return True
        End If
    End Function


    Sub Main()
        Dim linkedList(0 To 9) As node
        Dim StartPointer As Integer = 0
        Dim emptyList As Integer = 5


        linkedList(0).data = 1 : linkedList(0).nextnode = 1
        linkedList(1).data = 5 : linkedList(1).nextnode = 4
        linkedList(2).data = 6 : linkedList(2).nextnode = 7
        linkedList(3).data = 7 : linkedList(3).nextnode = -1
        linkedList(4).data = 2 : linkedList(4).nextnode = 2
        linkedList(5).data = 0 : linkedList(5).nextnode = 6
        linkedList(6).data = 0 : linkedList(6).nextnode = 8
        linkedList(7).data = 56 : linkedList(7).nextnode = 3
        linkedList(8).data = 0 : linkedList(8).nextnode = 9
        linkedList(9).data = 0 : linkedList(9).nextnode = -1
        Call outputNodes(linkedList, StartPointer)

        Console.ReadKey()

    End Sub

End Module

