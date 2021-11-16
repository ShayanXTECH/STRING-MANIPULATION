Module Module1

    Sub Main()

        Dim str As String
        Dim COUNT1, COUNT2, COUNT3, HIGHEST As Integer
        Dim CHAR1, CHAR2, HIGHESTCHAR As Char

        str = " "
        COUNT1 = 0
        COUNT2 = 0
        COUNT3 = 0
        CHAR1 = " "
        CHAR2 = " "
        HIGHESTCHAR = " "
        HIGHEST = 0

        Console.WriteLine("ENTER A STRING: ")
        str = Console.ReadLine

        For COUNT1 = 1 To Len(str)
            CHAR1 = Mid(str, COUNT1, 1)

            COUNT3 = 0

            For COUNT2 = 1 To Len(str)
                CHAR2 = Mid(str, COUNT2, 1)
                If CHAR1 = CHAR2 Then
                    COUNT3 = COUNT3 + 1


                    END IF
            Next
            If COUNT3 > HIGHEST Then
                HIGHESTCHAR = CHAR1
                HIGHEST = COUNT3
            End If
        Next

        Console.WriteLine(HIGHESTCHAR & " IS REPEATED " & HIGHEST & " TIMES")

        Console.ReadKey()

    End Sub

End Module
