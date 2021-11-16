Module Module1

    Sub Main()

        Dim STR1, STR2 As String

        Dim A As Integer
        Dim ISPANAGRAM As Boolean
        Dim THISCHAR As Char

        THISCHAR = " "
        STR1 = " "
        STR2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
       
        ISPANAGRAM = True
        A = 0

        Console.WriteLine("ENTER A STRING: ")
        STR1 = Console.ReadLine


        For A = 1 To Len(STR2)
            THISCHAR = Mid(STR1, A, 1)
            If InStr(STR1, THISCHAR) = 0 Then
                ISPANAGRAM = False
                Exit For
            End If



        Next

        If ISPANAGRAM = True Then
            Console.WriteLine("THIS STRING IS PANAGRAM")
        Else

            Console.WriteLine("THIS STRING IS NOT PANAGRAM")

        End If

        Console.ReadKey()














    End Sub

End Module
