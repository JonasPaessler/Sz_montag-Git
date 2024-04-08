Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        For i = 1 To 5
            Console.WriteLine(i)
            If i = 5 Then
                Console.WriteLine("ich bin jetzt bei 5!")
            End If
        Next


    End Sub
End Module
