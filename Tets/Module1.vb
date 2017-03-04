Module Module1

    Sub Main()
        Console.WriteLine("Hello World!")
        For i = 0 To 10
            Console.WriteLine(i)
        Next
        Dim string12 As String = "    111   sample string"
        Dim numFound As Boolean
        For i = 0 To string12.Length - 1
            If IsNumeric(string12.Chars(i)) And numFound <> True Then
                Console.WriteLine("Numbers were foud!")
                numFound = True
            End If
        Next
        Console.ReadKey()


    End Sub

End Module
