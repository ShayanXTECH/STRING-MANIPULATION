Module Module1

    Sub Main()
        Dim str1, str2, char1, char2 As String
        STR1 = ""
        STR2 = ""
        CHAR1 = ""
        CHAR2 = ""



        Console.WriteLine("Enter a string: ")
        str1 = Console.ReadLine

        If Len(str1) > 2 Then
            char1 = Left(str1, 2)
            char2 = Right(str1, 2)
            str2 = char1 + char2

            Console.WriteLine("Processed string is: " & str2)


        Else
            Console.WriteLine("Output:" & str1)


        End If


        

        Console.ReadKey()



    End Sub

End Module
