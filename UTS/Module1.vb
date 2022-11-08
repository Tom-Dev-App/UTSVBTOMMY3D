Imports System.Console
Imports System.IO
Module Module1
    Dim CurrentDateTime As String = DateTime.Now.ToString("dd'/'MM'/'yyyy-HH:mm:ss")
    Dim arrJabatan() As String = {"Kepala", "Manager", "Umum"}
    Dim arrGolongan() As Integer = {1, 2, 3}
    Dim input As String
    Dim arrLength, dataInt As Integer
    Dim tigaPilihan() As String = {"A", "B", "C"}
    Dim duaPilihan() As String = {"A", "B"}
    Dim mulaiUlang As String
    Dim selectedDATA, myStr As String
    Dim ulangPilihan, statusPilihan, myBool As Boolean
    Dim panjangPilihan, selectedInput As Integer
    Dim jenisKelamin() As String = {"Laki-laki", "Perempuan"}
    Dim statusKawin() As String = {"Belum Kawin", "Kawin"}
    Dim nestedLoop As Boolean
    Dim dataUser(14) As String
    Dim myInt, myIntSatu, myIntDua, myinTiga As Integer
    Dim statusPegawai() As String = {"Tetap", "Honorer"}
    Dim arrGajiPokok() As Integer = {1500000, 2500000, 3500000}
    Dim arrPersenTunjanganIstri() As Single = {0.01, 0.03, 0.05}
    Dim persenTunjanganAnak, mySingle As Single
    Dim biayaKop As Integer
    Dim arrBiayaJabatan() As Single = {0.005, 0.003}
    Dim arrDanaPensiun() As Single = {0.005, 0.003}



    Sub Main()
        mulaiUlang = True
        Do Until mulaiUlang = False
            'NILAI DEFAULT
            myInt = 0
            persenTunjanganAnak = 0.01
            biayaKop = 5000
            dataInt = 0
            myInt = 0
            myIntDua = 0
            myinTiga = 0
            mySingle = 0
            input = ""

            'Program Starts Here!
            NamaPegawai()
            JenisKelaminPegawai()
            StatusKawinPegawai()
            JmlAnakPegawai()
            JabatanPegawai()
            StatusKerjaPegawai()
            GolonganPegawai()
            HitungTunjanganIstri()
            HitungTunjanganAnak()
            HitungGajiKotor()
            HitungPotonganKoperasi()
            HitungBiayaJabatan()
            HitungBiayaPensiun()
            HitungGajibersih()
            TampilHasil()
            printNota()

            'ASK TO START FROM BEGINNING
            ulangPilihan = True
            Do Until ulangPilihan = False
                Write(" > Mulai Ulang T untuk mengakhiri? => ")
                input = UCase(ReadLine())
                If input <> "T" Then
                    ulangPilihan = False
                    mulaiUlang = True
                Else
                    ulangPilihan = False
                    mulaiUlang = False
                End If
            Loop

            Clear()
        Loop

    End Sub


    Function cekTigaInput(panjangPilihan)
        Do Until ulangPilihan = False
            Write(" > Masukkan Kode: ")
            input = UCase(ReadLine())

            'Cek jika input salah
            statusPilihan = False
            For i = 0 To panjangPilihan
                If tigaPilihan(i) = input Then
                    statusPilihan = True
                    ulangPilihan = False

                End If
            Next

            If statusPilihan = False Then
                WriteLine("  > Kode Salah!")
                WriteLine("   > Masukkan kode lagi!")
                ulangPilihan = True
            End If

            'input = "A"
            'A = JADI 0, B = 1, DAN C = 2
            For i = 0 To panjangPilihan
                If tigaPilihan(i) = input Then
                    'INPUT A = 0
                    'SELECTEDINPUT = 0
                    selectedInput = i
                    Exit For
                End If
            Next
        Loop
        Return selectedInput
    End Function

    Function cekDuaInput(panjangPilihan)
        Do Until ulangPilihan = False
            Write(" > Masukkan Kode: ")
            input = UCase(ReadLine())

            'Cek jika input salah
            statusPilihan = False
            For i = 0 To panjangPilihan
                If duaPilihan(i) = input Then
                    statusPilihan = True
                    ulangPilihan = False

                End If
            Next

            If statusPilihan = False Then
                WriteLine("  > Kode Salah!")
                WriteLine("   > Masukkan kode lagi!")
                ulangPilihan = True
            End If

            'input = "A"
            'A = JADI 0, B = 1, DAN C = 2
            For i = 0 To panjangPilihan
                If duaPilihan(i) = input Then
                    'INPUT A = 0
                    'SELECTEDINPUT = 0
                    selectedInput = i
                    Exit For
                End If
            Next
        Loop
        Return selectedInput
    End Function

    Sub JabatanPegawai()
        ulangPilihan = True
        WriteLine("--------------------------------------------------------------")
        WriteLine("                     Pilih Jabatan Sesuai Kode")
        For i = 0 To arrJabatan.Length - 1
            WriteLine(tigaPilihan(i) & ". " & arrJabatan(i))
        Next
        WriteLine("--------------------------------------------------------------")
        'MASUK KE FUNGSI
        cekTigaInput(arrJabatan.Length - 1)
        'DEBUGGING
        'WriteLine("SELECTED INPUT IS " & selectedInput)

        selectedDATA = arrJabatan(selectedInput)
        WriteLine(" > Jabatan Terpilih:" & selectedDATA)
        WriteLine("")
        WriteLine("============================DONE===============================")
        WriteLine("")
        WriteLine("")
        'SIMPAN DATA KE ARRAY
        dataUser(4) = selectedDATA
    End Sub

    Sub JenisKelaminPegawai()
        ulangPilihan = True
        WriteLine("")
        WriteLine("")
        WriteLine("--------------------------------------------------------------")
        WriteLine("                  Pilih Jenis kelamin Sesuai Kode")
        For i = 0 To jenisKelamin.Length - 1
            WriteLine(tigaPilihan(i) & ". " & jenisKelamin(i))
        Next
        WriteLine("--------------------------------------------------------------")
        'MASUK KE FUNGSI
        cekDuaInput(jenisKelamin.Length - 1)
        'DEBUGGING
        'WriteLine("SELECTED INPUT IS " & selectedInput)

        selectedDATA = jenisKelamin(selectedInput)
        WriteLine(" > Jenis kelamin Terpilih:" & selectedDATA)
        WriteLine("")
        WriteLine("============================DONE===============================")
        WriteLine("")
        WriteLine("")
        'SIMPAN DATA KE ARRAY
        dataUser(1) = selectedDATA
    End Sub
    Sub StatusKawinPegawai()
        ulangPilihan = True
        WriteLine("--------------------------------------------------------------")
        WriteLine("                  Pilih Status Kawin Sesuai Kode")
        For i = 0 To statusKawin.Length - 1
            WriteLine(tigaPilihan(i) & ". " & statusKawin(i))
        Next
        WriteLine("--------------------------------------------------------------")
        'MASUK KE FUNGSI
        cekDuaInput(statusKawin.Length - 1)
        'DEBUGGING
        'WriteLine("SELECTED INPUT IS " & selectedInput)

        selectedDATA = statusKawin(selectedInput)
        WriteLine("Status kawin Terpilih:" & selectedDATA)
        WriteLine("")
        WriteLine("============================DONE===============================")
        WriteLine("")
        WriteLine("")
        'SIMPAN STATUS KAWIN KE ARRAY
        dataUser(2) = selectedDATA

    End Sub

    Sub StatusKerjaPegawai()
        ulangPilihan = True
        WriteLine("")
        WriteLine("")
        WriteLine("--------------------------------------------------------------")
        WriteLine("                 Pilih Status Pegawai Sesuai Kode")
        For i = 0 To statusPegawai.Length - 1
            WriteLine(duaPilihan(i) & ". " & statusPegawai(i))
        Next
        WriteLine("--------------------------------------------------------------")
        'MASUK KE FUNGSI
        cekDuaInput(statusPegawai.Length - 1)
        'DEBUGGING
        'WriteLine("SELECTED INPUT IS " & selectedInput)

        selectedDATA = statusPegawai(selectedInput)
        WriteLine("Status Pegawai Terpilih:" & selectedDATA)
        WriteLine("")
        WriteLine("============================DONE===============================")
        WriteLine("")
        WriteLine("")

        'SIMPAN DATA KE ARRAY
        dataUser(5) = selectedDATA
    End Sub
    Sub GolonganPegawai()
        ulangPilihan = True
        WriteLine("")
        WriteLine("")
        WriteLine("--------------------------------------------------------------")
        WriteLine("                Pilih Gaji Pokok Sesuai Kode")
        For i = 0 To arrGajiPokok.Length - 1
            WriteLine(tigaPilihan(i) & ". Golongan " & i + 1 & " = " & arrGajiPokok(i))
        Next
        WriteLine("--------------------------------------------------------------")
        'MASUK KE FUNGSI
        cekTigaInput(arrGajiPokok.Length - 1)
        'DEBUGGING
        'WriteLine("SELECTED INPUT IS " & selectedInput)

        selectedDATA = arrGolongan(selectedInput)
        WriteLine("Golongan Pegawai Terpilih:" & selectedDATA)
        WriteLine("")
        WriteLine("============================DONE===============================")
        WriteLine("")
        WriteLine("")
        'SIMPAN GOL PEGAWAI KE ARRAY
        dataUser(6) = selectedDATA
        'MENCARI GAJI POKOK
        For i = 0 To arrGolongan.Length - 1
            If arrGolongan(i) = Convert.ToInt16(selectedDATA) Then
                selectedDATA = arrGajiPokok(i)
                Exit For
            End If
        Next
        'SIMPAN GAJI POKOK KE DALAM ARRAY
        dataUser(7) = selectedDATA
    End Sub

    Sub HitungTunjanganIstri()
        'Laki" Kawin
        'Gaji pokok * persentase tunj istri sesuai golongan gaji pokok
        'gol 1 = 1%, gol 2 = 3%, gol 3 = 5%
        dataInt = 0
        If dataUser(1) = jenisKelamin(0) And dataUser(2) = statusKawin(1) Then
            If arrGolongan(0) = dataUser(6) Then
                mySingle = arrPersenTunjanganIstri(0)
                myInt = arrGajiPokok(0)
                dataInt = mySingle * myInt
            ElseIf arrGolongan(1) = dataUser(6) Then
                mySingle = arrPersenTunjanganIstri(1)
                myInt = arrGajiPokok(1)
                dataInt = mySingle * myInt
            ElseIf arrGolongan(2) = dataUser(6) Then
                mySingle = arrPersenTunjanganIstri(2)
                myInt = arrGajiPokok(2)
                dataInt = mySingle * myInt
            End If
        End If
        'SIMPAN DATA KE ARRAY
        dataUser(8) = dataInt

    End Sub
    Sub HitungTunjanganAnak()
        'Status Kawin
        'Maksimal tunjangan Anak = 2
        'persentase tunj anak * gajiPokok
        dataInt = 0
        If dataUser(2) = statusKawin(1) Then
            If dataUser(3) = 1 Then
                myInt = dataUser(7)
                dataInt = myInt * persenTunjanganAnak
            Else
                'Max 2 anak
                myInt = dataUser(7)
                dataInt = myInt * persenTunjanganAnak * 2
            End If
        End If
        'SIMPAN DATA KE ARRAY
        dataUser(9) = dataInt
    End Sub
    Sub HitungGajiKotor()
        'Gaji Total = Gaji Pokok + Tunjangan Anak + Tunjangan Istri
        myInt = Convert.ToInt32(dataUser(7))
        myIntSatu = Convert.ToInt32(dataUser(8))
        myIntDua = Convert.ToInt32(dataUser(9))
        dataInt = myInt + myIntSatu + myIntDua
        'Simpan data ke array
        dataUser(10) = dataInt
    End Sub
    Sub HitungPotonganKoperasi()
        dataInt = 0
        'Pegawai tetap
        'pegawai tetap = 5000, honorer = 0
        If dataUser(5) = statusPegawai(0) Then
            dataInt = biayaKop
        End If
        'SIMPAN DATA KE ARRAY
        dataUser(11) = dataInt
    End Sub
    Sub HitungBiayaJabatan()
        'Berlaku Semua Pegawai
        'Kepala : 0,5% dari Gaji Pokok
        'Manager dan Sekretaris : 0,3% dari Gaji Pokok
        ' persentase dari jabatan * gaji pokok
        myInt = dataUser(7)
        If dataUser(4) = arrJabatan(0) Then
            mySingle = arrBiayaJabatan(0)
            dataInt = mySingle * myInt
        ElseIf dataUser(4) = arrJabatan(1) Or dataUser(4) = arrJabatan(2) Then
            mySingle = arrBiayaJabatan(1)
            dataInt = mySingle * myInt
        End If
        'SIMPAN DATA KE ARRAY
        dataUser(12) = dataInt
    End Sub
    Sub HitungBiayaPensiun()
        'Berlaku Pegawai tetap
        'Kepala : 0,5% dari Gaji Pokok
        'Manager dan Sekretaris : 0,3% dari Gaji Pokok
        ' persentase dari danapensiun * gaji pokok
        dataInt = 0
        myInt = dataUser(7)
        If dataUser(5) = statusPegawai(0) Then
            If dataUser(4) = arrJabatan(0) Then
                mySingle = arrDanaPensiun(0)
                dataInt = mySingle * myInt
            ElseIf dataUser(4) = arrJabatan(1) Or dataUser(4) = arrJabatan(2) Then
                mySingle = arrDanaPensiun(1)
                dataInt = mySingle * myInt
            End If
        End If

        'SIMPAN DATA KE ARRAY
        dataUser(13) = dataInt
    End Sub
    Sub HitungGajibersih()
        'Gaji bersih = gaji kotor - koperasi - biaya jabatan - dana pensiun
        myInt = dataUser(10)
        myIntSatu = dataUser(11)
        myIntDua = dataUser(12)
        myinTiga = dataUser(13)
        dataInt = myInt - myIntSatu - myIntDua - myinTiga
        'SIMPAN KE DALAM ARRAY
        dataUser(14) = dataInt
    End Sub

    Sub TampilHasil()

        WriteLine("")
        WriteLine("")
        WriteLine("")
        WriteLine("--------------------------------------------------------------")
        WriteLine("SLIP GAJI: " & dataUser(0))
        WriteLine("--------------------------------------------------------------")
        WriteLine("1.  Golongan                     = " & dataUser(6))
        WriteLine("2.  Jabatan                      = " & dataUser(4))
        WriteLine("3.  Status Pegawai               = " & dataUser(5))
        WriteLine("4.  Jenis Kelamin                = " & dataUser(1))
        WriteLine("5.  Status Kawin                 = " & dataUser(2))
        WriteLine("6.  Jumlah Anak                  = " & dataUser(3))
        WriteLine("7.  Gaji Pokok                   = " & FormatNumber(Convert.ToInt32(dataUser(7))), 0, TriState.True, 0)
        WriteLine("8.  Tunjangan Istri              = " & FormatNumber(Convert.ToInt32(dataUser(8))), 0, TriState.True, 0)
        WriteLine("9.  Tunjangan Anak               = " & FormatNumber(Convert.ToInt32(dataUser(9))), 0, TriState.True, 0)
        WriteLine("==============================================================")
        WriteLine("             Total Gaji Bruto    = " & FormatNumber(Convert.ToInt32(dataUser(10))), 0, TriState.True, 0)
        WriteLine("10. Potongan Koperasi            = " & FormatNumber(Convert.ToInt32(dataUser(11))), 0, TriState.True, 0)
        WriteLine("11. Biaya Jabatan                = " & FormatNumber(Convert.ToInt32(dataUser(12))), 0, TriState.True, 0)
        WriteLine("12. Dana Pensiun                 = " & FormatNumber(Convert.ToInt32(dataUser(13))), 0, TriState.True, 0)
        WriteLine("==============================================================")
        WriteLine("	           Total Gaji Bersih/Netto     = " & FormatNumber(Convert.ToInt32(dataUser(14))), 0, TriState.True, 0)
        WriteLine("")
        WriteLine("--------------------------------------------------------------")
        WriteLine("                                PRINT: " & CurrentDateTime)
        WriteLine("--------------------------------------------------------------")

    End Sub
    Sub NamaPegawai()
        WriteLine("--------------------------------------------------------------")
        WriteLine("")
        Write(" > Masukkan nama: ")
        input = ReadLine()
        WriteLine("")
        WriteLine("--------------------------------------------------------------")
        WriteLine("  > Nama: " & input)
        WriteLine("============================DONE===============================")

        'Masukkan ke array
        dataUser(0) = input


    End Sub
    Sub JmlAnakPegawai()
        input = 0
        'Loop mengecek jika inputan bukan int
        nestedLoop = True
        WriteLine("--------------------------------------------------------------")
        WriteLine("")
        Do Until nestedLoop = False
            Write("Masukkan Jumlah Anak: ")
            Try
                dataInt = ReadLine()
                If Not dataInt >= 0 Then
                    WriteLine("Yang Anda Ketik Angka Negatif!")
                    Write("Masukkan Jumlah Anak: ")
                    dataInt = ReadLine()
                End If
                nestedLoop = False
            Catch ex As InvalidCastException
                WriteLine("Yang Anda Ketik Bukan Angka!")
            End Try
        Loop
        WriteLine("")
        WriteLine("============================DONE===============================")
        WriteLine("")
        WriteLine("")
        'SIMPAN DATA JUMLAH ANAK KE ARRAY
        dataUser(3) = dataInt
    End Sub

    Sub printNota()
        Write("Print Nota Ketik Y/T? :")
        input = UCase(ReadLine())
        If input = "Y" Then
            Dim mydate As String = DateTime.Now.ToString("dd'-'MM'-'yyyy-HH-mm-ss")
            Dim filename As String
            filename = "SLIP GAJI " & dataUser(0) & " " & mydate & ".txt"
            Dim myWriter As StreamWriter



            myWriter = My.Computer.FileSystem.OpenTextFileWriter("d:\" & filename, True)


            myWriter.WriteLine("--------------------------------------------------------------")
            myWriter.WriteLine("SLIP GAJI: " & dataUser(0))
            myWriter.WriteLine("--------------------------------------------------------------")
            myWriter.WriteLine("1.  Golongan                     = " & dataUser(6))
            myWriter.WriteLine("2.  Jabatan                      = " & dataUser(4))
            myWriter.WriteLine("3.  Status Pegawai               = " & dataUser(5))
            myWriter.WriteLine("4.  Jenis Kelamin                = " & dataUser(1))
            myWriter.WriteLine("5.  Status Kawin                 = " & dataUser(2))
            myWriter.WriteLine("6.  Jumlah Anak                  = " & dataUser(3))
            myWriter.WriteLine("7.  Gaji Pokok                   = " & FormatNumber(Convert.ToInt32(dataUser(7))), 0, TriState.True, 0)
            myWriter.WriteLine("8.  Tunjangan Istri              = " & FormatNumber(Convert.ToInt32(dataUser(8))), 0, TriState.True, 0)
            myWriter.WriteLine("9.  Tunjangan Anak               = " & FormatNumber(Convert.ToInt32(dataUser(9))), 0, TriState.True, 0)
            myWriter.WriteLine("==============================================================")
            myWriter.WriteLine("             Total Gaji Bruto    = " & FormatNumber(Convert.ToInt32(dataUser(10))), 0, TriState.True, 0)
            myWriter.WriteLine("10. Potongan Koperasi            = " & FormatNumber(Convert.ToInt32(dataUser(11))), 0, TriState.True, 0)
            myWriter.WriteLine("11. Biaya Jabatan                = " & FormatNumber(Convert.ToInt32(dataUser(12))), 0, TriState.True, 0)
            myWriter.WriteLine("12. Dana Pensiun                 = " & FormatNumber(Convert.ToInt32(dataUser(13))), 0, TriState.True, 0)
            myWriter.WriteLine("==============================================================")
            myWriter.WriteLine("	           Total Gaji Bersih/Netto     = " & FormatNumber(Convert.ToInt32(dataUser(14))), 0, TriState.True, 0)
            myWriter.WriteLine("")
            myWriter.WriteLine("--------------------------------------------------------------")
            myWriter.WriteLine("                                PRINT: " & CurrentDateTime)
            myWriter.WriteLine("--------------------------------------------------------------")
            myWriter.Close()

        End If




    End Sub
End Module
