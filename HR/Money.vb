Public Module Money
    Public Enum MoneyLanguage As Short
        English
        Indonesian
    End Enum

    ''' <summary>
    ''' Spells the money to words.
    ''' </summary>
    ''' <param name="l">Language of the returned string.</param>
    ''' <param name="money">Money value.</param>
    ''' <param name="currency">The currency.</param>
    ''' <returns></returns>
    Public Function SpellMoneyToWords(ByVal l As MoneyLanguage, ByVal money As Decimal, Optional ByVal currency As String = "") As String
        Select Case l
            Case MoneyLanguage.English
                Return SpellNumber(money, currency)
            Case MoneyLanguage.Indonesian
                Return Terbilang(money, currency) 'SpellMoneyToWords(MoneyLanguage.English, money) & currency
            Case Else
                Return "<Invalid language selection>"
        End Select
    End Function

#Region "Terbilang Indonesia"
    Public Function PembulatanIndonesia(ByVal angka As Decimal, Optional ByVal DecimalPlace As Integer = 0) As Decimal
        Dim multiplier As Decimal = CDec(10 ^ DecimalPlace)
        Dim scaledValue As Decimal = angka * multiplier
        Dim bulat As Decimal = Fix(scaledValue)
        Dim desimal As Decimal = scaledValue - bulat
        Dim roundedScaledValue As Decimal

        If desimal >= 0.5 Then
            roundedScaledValue = bulat + 1
        Else
            roundedScaledValue = bulat
        End If

        Return roundedScaledValue / multiplier
    End Function


    'Public Function PembulatanIndonesia(ByVal angka As Decimal) As Long
    '    Dim bulat As Long = Fix(angka)
    '    Dim desimal As Decimal = angka - bulat
    '    If desimal >= 0.5 Then
    '        Return bulat + 1
    '    Else
    '        Return bulat
    '    End If
    'End Function

    Private Function Terbilang(ByVal Angka As Decimal, ByVal MataUang As String) As String
        Terbilang = ""
        Try
            Dim Desimal As Decimal
            Dim sDesimal As String
            Dim Koma As String
            'Dim M As Object
            Dim sAngka As String
            Dim locttk As Integer
            Dim jAngka As Integer
            'Dim bilangan As String

            Desimal = 0
            Koma = ""
            sDesimal = ""
            Angka = Math.Abs(Angka)
            Angka = Math.Round(Angka, 4)

            sAngka = Trim(Str(Angka))
            jAngka = Len(sAngka)
            locttk = InStrRev(sAngka, ".")
            If locttk > 0 Then
                sDesimal = Right(sAngka, jAngka - locttk)
                If Len(sDesimal) = 1 Then Desimal = Val(sDesimal) * 10 Else Desimal = Val(sDesimal)
                Angka = Val(Left(sAngka, locttk - 1))
            End If

            If jAngka <= 0 Then Return "" 'kalau kosong keluar
            If Angka <= 0 Then Terbilang = "Nol " : Return "Nol" 'kalau kosong keluar
            If Angka >= 1.0E+15 Then Terbilang = "Error" : Exit Function

            If Desimal <> 0 Then
                Terbilang = Triliunan(Angka)
                Dim strDesimal As String = "Koma "
                'sDesimal = "Koma " '& Triliunan(Desimal)
                sDesimal = CheckDecimalZero(sDesimal.ToString)
                For Each c As Char In sDesimal ' strDesimal
                    Dim d As Decimal = Decimal.Parse(c)
                    strDesimal &= Satuan(d, True)
                Next 

                Terbilang = Terbilang & strDesimal & MataUang
            Else
                Terbilang = Triliunan(Angka) & MataUang
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Function CheckDecimalZero(ByVal d As String) As String
        CheckDecimalZero = ""
        Dim BackZero As String = ""
        For Each c As Char In d
            If c = "0" Then
                BackZero &= c
            Else
                BackZero = ""
            End If

            CheckDecimalZero &= c

        Next


        Dim a() As String = Split(d, BackZero)
        CheckDecimalZero = a(0)
    End Function

    Private Function Satuan(ByVal satAngka As Decimal, Optional PromptZero As Boolean = False) As String
        Select Case satAngka
            Case 0
                If PromptZero Then
                    Satuan = "Nol "
                Else
                    Satuan = ""
                End If
            Case 1
                Satuan = "Satu "
            Case 2
                Satuan = "Dua "
            Case 3
                Satuan = "Tiga "
            Case 4
                Satuan = "Empat "
            Case 5
                Satuan = "Lima "
            Case 6
                Satuan = "Enam "
            Case 7
                Satuan = "Tujuh "
            Case 8
                Satuan = "Delapan "
            Case 9
                Satuan = "Sembilan "
            Case 10
                Satuan = "Sepuluh "
            Case 11
                Satuan = "Sebelas "
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function Puluhan(ByVal pulAngka As Decimal) As String
        If pulAngka < 12 Then
            Puluhan = Satuan(pulAngka)
        ElseIf Left(pulAngka, 1) = 1 Then
            Puluhan = Satuan(Right(pulAngka, 1)) & "Belas "
        Else
            Puluhan = Satuan(Left(pulAngka, 1)) & "Puluh " & Satuan(Right(pulAngka, 1))
        End If
    End Function

    Private Function Ratusan(ByVal ratAngka As Decimal) As String
        Ratusan = ""
        If ratAngka = 0 Then
            Exit Function
        ElseIf ratAngka >= 100 And ratAngka < 200 Then
            Ratusan = "Seratus "
        ElseIf ratAngka >= 200 And ratAngka < 1000 Then
            Ratusan = Satuan(Left(ratAngka, 1)) & "Ratus "
        End If
        Ratusan = Ratusan & Puluhan(Val(Right(ratAngka, 2)))
    End Function

    Private Function Ribuan(ByVal ribAngka As Decimal) As String
        Ribuan = ""
        If ribAngka = 0 Then
            Exit Function
        ElseIf ribAngka >= 1000 And ribAngka < 2000 Then
            Ribuan = "Seribu "
        ElseIf ribAngka >= 2000 And ribAngka < 10000 Then
            Ribuan = Satuan(Left(ribAngka, 1)) & "Ribu "
        ElseIf ribAngka >= 10000 And ribAngka < 100000 Then
            Ribuan = Puluhan(Left(ribAngka, 2)) & "Ribu "
        ElseIf ribAngka >= 10000 And ribAngka < 1000000 Then
            Ribuan = Ratusan(Left(ribAngka, 3)) & "Ribu "
        End If
        Ribuan = Ribuan & Ratusan(Right(ribAngka, 3))
    End Function

    Private Function Jutaan(ByVal jutAngka As Decimal) As String
        Jutaan = ""
        If jutAngka = 0 Then
            Exit Function
        ElseIf jutAngka >= 1000000 And jutAngka < 10000000 Then
            Jutaan = Satuan(Left(jutAngka, 1)) & "Juta "
        ElseIf jutAngka >= 10000000 And jutAngka < 100000000 Then
            Jutaan = Puluhan(Left(jutAngka, 2)) & "Juta "
        ElseIf jutAngka >= 100000000 And jutAngka < 1000000000 Then
            Jutaan = Ratusan(Left(jutAngka, 3)) & "Juta "
        End If
        Jutaan = Jutaan & Ribuan(Right(jutAngka, 6))
    End Function

    Private Function Milyaran(ByVal milAngka As Decimal) As String
        Milyaran = ""
        If milAngka = 0 Then
            Exit Function
        ElseIf milAngka >= 1000000000 And milAngka < 10000000000.0# Then
            Milyaran = Satuan(Left(milAngka, 1)) & "Milyar "
        ElseIf milAngka >= 10000000000.0# And milAngka < 100000000000.0# Then
            Milyaran = Puluhan(Left(milAngka, 2)) & "Milyar "
        ElseIf milAngka >= 100000000000.0# And milAngka < 1000000000000.0# Then
            Milyaran = Ratusan(Left(milAngka, 3)) & "Milyar "
        ElseIf milAngka >= 100000000000000.0# And milAngka < 1.0E+15 Then
            Milyaran = Jutaan(Left(milAngka, 6)) & "Milyar "
        End If

        Milyaran = Milyaran & Jutaan(Right(milAngka, 9))
    End Function

    Private Function Triliunan(ByVal trilAngka As Decimal) As String
        Triliunan = ""
        If trilAngka = 0 Then
            Triliunan = ""
        ElseIf trilAngka >= 1000000000000.0# And trilAngka < 10000000000000.0# Then
            Triliunan = Satuan(Left(trilAngka, 1)) & "Triliun "
        ElseIf trilAngka >= 10000000000000.0# And trilAngka < 100000000000000.0# Then
            Triliunan = Puluhan(Left(trilAngka, 2)) & "Triliun "
        ElseIf trilAngka >= 100000000000000.0# And trilAngka < 1.0E+15 Then
            Triliunan = Ratusan(Left(trilAngka, 3)) & "Triliun "
        ElseIf trilAngka >= 1.0E+17 And trilAngka < 1.0E+18 Then
            Triliunan = Jutaan(Left(trilAngka, 6)) & "Triliun "
        ElseIf trilAngka >= 1.0E+20 And trilAngka < 1.0E+21 Then
            Triliunan = Milyaran(Left(trilAngka, 9)) & "Triliun "
        End If

        Triliunan = Triliunan & Milyaran(Right(trilAngka, 12))
    End Function
#End Region

#Region "Terbilang English"
    'http://www.demtron.com/blog/post/2009/02/02/VBNet-Converting-Number-to-Words.aspx
    Private Function SpellNumber(ByVal MyNumber As String, ByVal Currency As String) As String
        Dim Dollars As String = ""
        Dim Cents As String = ""
        Dim Temp As String = ""
        Dim DecimalPlace, Count As Integer
        Dim Place(9) As String
        Place(2) = " Thousand "
        Place(3) = " Million "
        Place(4) = " Billion "
        Place(5) = " Trillion "
        ' String representation of amount.
        MyNumber = Trim(Str(MyNumber))
        ' Position of decimal place 0 if none.
        DecimalPlace = InStr(MyNumber, ".")
        ' Convert cents and set MyNumber to dollar amount.
        If DecimalPlace > 0 Then
            Cents = GetTens(Left(Mid(MyNumber, DecimalPlace + 1) & _
            "00", 2))
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If
        Count = 1
        Do While MyNumber <> ""
            Temp = GetHundreds(Right(MyNumber, 3))
            If Temp <> "" Then Dollars = Temp & Place(Count) & Dollars
            If Len(MyNumber) > 3 Then
                MyNumber = Left(MyNumber, Len(MyNumber) - 3)
            Else
                MyNumber = ""
            End If
            Count = Count + 1
        Loop
        Select Case Dollars
            Case ""
                Dollars = "No " & Currency
            Case "One"
                Dollars = "One " & Currency
            Case Else
                Dollars = Dollars & " " & Currency
        End Select
        Select Case Cents
            Case ""
                Cents = " and No Cents"
            Case "One"
                Cents = " and One Cent"
            Case Else
                Cents = " and " & Cents & " Cents"
        End Select
        SpellNumber = Dollars & Cents
    End Function

    Private Function GetHundreds(ByVal MyNumber As String) As String
        Dim theResult As String = ""
        If Val(MyNumber) = 0 Then : Return "" : Exit Function : End If
        MyNumber = Right("000" & MyNumber, 3)
        ' Convert the hundreds place.
        If Mid(MyNumber, 1, 1) <> "0" Then
            theResult = GetDigit(Mid(MyNumber, 1, 1)) & " Hundred "
        End If
        ' Convert the tens and ones place.
        If Mid(MyNumber, 2, 1) <> "0" Then
            theResult = theResult & GetTens(Mid(MyNumber, 2))
        Else
            theResult = theResult & GetDigit(Mid(MyNumber, 3))
        End If
        GetHundreds = theResult
    End Function

    Private Function GetTens(ByVal TensText As String) As String
        Dim Result As String
        Result = ""           ' Null out the temporary function value.
        If Val(Left(TensText, 1)) = 1 Then   ' If value between 10-19...
            Select Case Val(TensText)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else                                 ' If value between 20-99...
            Select Case Val(Left(TensText, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            Result = Result & GetDigit _
            (Right(TensText, 1))  ' Retrieve ones place.
        End If
        GetTens = Result
    End Function

    Private Function GetDigit(ByVal Digit As String) As String
        Select Case Val(Digit)
            Case 1 : GetDigit = "One"
            Case 2 : GetDigit = "Two"
            Case 3 : GetDigit = "Three"
            Case 4 : GetDigit = "Four"
            Case 5 : GetDigit = "Five"
            Case 6 : GetDigit = "Six"
            Case 7 : GetDigit = "Seven"
            Case 8 : GetDigit = "Eight"
            Case 9 : GetDigit = "Nine"
            Case Else : GetDigit = ""
        End Select
    End Function
#End Region
End Module
