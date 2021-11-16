Module Module1

    Sub Main()
        Dim str1, str2, D As String
        Dim notpos, badpos As Integer

        D = ""
        str1 = ""
        str2 = ""
        notpos = 0
        badpos = 0


        Console.WriteLine("Enter a string: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        notpos = InStr(str1, "NOT")
        badpos = InStr(str1, "BAD")

        If badpos > notpos Then
            str2 = Left(str1, notpos - 1) & "GOOD"
            D = Right(str1, Len(str1) - badpos - 2)
            Console.WriteLine("Processed string is:" & str2 & D)
        Else

            Console.WriteLine("THIS STRING CAN NOT BE PROCESSED")
        End If


        Console.ReadKey()

    End Sub

End Module
