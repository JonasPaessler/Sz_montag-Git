Imports System

Module Program
    Public Test As Boolean
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        For i = 1 To 5
            Console.WriteLine(i)
            If i = 5 Then
                Console.WriteLine("ich bin jetzt bei 5!")
            End If

            Console.WriteLine(System.DateTime.Now)
        Next

        If Test = False Then
            Console.WriteLine("Test")

        End If

        'this is the for the Inc number 1

        'Public funktion AbInDenSüden

    End Sub



End Module
