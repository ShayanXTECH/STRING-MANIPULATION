Module Module1

    Sub Main()
        Dim STR As String
        Dim THISCHAR As Char
        Dim COUNTVOWEL, X As Integer

        STR = " "
        THISCHAR = " "
        COUNTVOWEL = 0
        X = 0

        Console.WriteLine("ENTER THE STRING: ")
        STR = Console.ReadLine

        STR = UCase(STR)

        For X = 1 To Len(STR)
            THISCHAR = Mid(STR, X, 1)

            Select Case THISCHAR
                Case "A" : COUNTVOWEL = COUNTVOWEL + 1
                Case "E" : COUNTVOWEL = COUNTVOWEL + 1
                Case "I" : COUNTVOWEL = COUNTVOWEL + 1
                Case "O" : COUNTVOWEL = COUNTVOWEL + 1
                Case "U" : COUNTVOWEL = COUNTVOWEL + 1

            End Select



        Next

        Console.WriteLine("VOWEL COUNTED ARE: " & COUNTVOWEL)
        Console.ReadKey()


    End Sub

End Module
