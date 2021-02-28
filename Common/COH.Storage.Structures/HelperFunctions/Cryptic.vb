Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Namespace HelperFunctions.Cryptic
    <HideModuleName> Public Module COH_Cryptic_Hashing

        Public Enum Cryptic_Hashing_SupportedMethods
            SHA1 = 0
            SHA256 = 1
            SHA384 = 2
            SHA512 = 3
            CRC16 = 4
            CRC32 = 5
            CRC8 = 6
        End Enum

#Region "Shared Functions - MD5"
        Public Function Calculate_MD5(ByVal filePath As String) As String
            Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
            Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            md5.ComputeHash(f)
            f.Close()
            Dim hash As Byte() = md5.Hash
            Dim buff As StringBuilder = New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            Dim md5string As String
            md5string = buff.ToString()
            Return md5string
        End Function
#End Region

#Region "Calculate Hash"
        Public Function CalculateHash_ToBase64(Method As Cryptic_Hashing_SupportedMethods, ByRef TheBytes As Byte()) As String
            Return Convert.ToBase64String(CalculateHash(Method, TheBytes))
        End Function
        Public Function CalculateHash(Method As Cryptic_Hashing_SupportedMethods, ByRef TheBytes As Byte()) As Byte()
            Select Case Method
                Case Cryptic_Hashing_SupportedMethods.SHA1
                    Return Calculate_SHA1(TheBytes)
                Case Cryptic_Hashing_SupportedMethods.SHA256
                    Return Calculate_SHA256(TheBytes)
                Case Cryptic_Hashing_SupportedMethods.SHA384
                    Return Calculate_SHA384(TheBytes)
                Case Cryptic_Hashing_SupportedMethods.SHA512
                    Return Calculate_SHA512(TheBytes)
                Case Cryptic_Hashing_SupportedMethods.CRC16
                    Return BitConverter.GetBytes(Calculate_CRC16(TheBytes))
                Case Cryptic_Hashing_SupportedMethods.CRC32
                    Return BitConverter.GetBytes(Calculate_CRC32(TheBytes))
                Case Cryptic_Hashing_SupportedMethods.CRC8
                    Return BitConverter.GetBytes(Calculate_CRC8(TheBytes))
            End Select
            Return Nothing
        End Function
#End Region

#Region "Shared Functions - SHA"
        Public Function Calculate_SHA1(ByRef TheBytes As Byte()) As Byte()
            Dim Result As New SHA1CryptoServiceProvider
            Return Result.ComputeHash(TheBytes)
        End Function
        Public Function Calculate_SHA256(ByRef TheBytes As Byte()) As Byte()
            Dim Result As New SHA256CryptoServiceProvider
            Return Result.ComputeHash(TheBytes)
        End Function
        Public Function Calculate_SHA384(ByRef TheBytes As Byte()) As Byte()
            Dim Result As New SHA384CryptoServiceProvider
            Return Result.ComputeHash(TheBytes)
        End Function
        Public Function Calculate_SHA512(ByRef TheBytes As Byte()) As Byte()
            Dim Result As New SHA512CryptoServiceProvider
            Return Result.ComputeHash(TheBytes)
        End Function
#End Region

#Region "Shared Functions - CRC8"
        Public Function Calculate_CRC8(ByRef TheBytes As Byte()) As Byte
            Dim checksum As Byte = 0
            For i As Integer = 0 To TheBytes.Length - 1
                checksum = (CInt(checksum) + TheBytes(i)) Mod 256
            Next
            If checksum = 0 Then
                Return 0
            Else
                Return CByte(256 - checksum)
            End If
        End Function
#End Region

#Region "Shared Functions - CRC16"
        Public Function Calculate_CRC16(ByRef TheBytes As Byte()) As Short
            Return Calculate_CRC16(TheBytes, 0, TheBytes.Length)
        End Function
        Public Function Calculate_CRC16(ByRef TheBytes As Byte(), Offset As Integer, Count As Integer) As Short
            Dim CRC16_TABLE As UInt16() = New UInt16() {0, &H8005, &H800F, 10, &H801B, 30, 20, &H8011, &H8033, &H36, 60, &H8039, 40, &H802D, &H8027, &H22, &H8063, &H66, &H6C, &H8069, 120, &H807D, &H8077, &H72, 80, &H8055, &H805F, 90, &H804B, &H4E, &H44, &H8041, &H80C3, &HC6, &HCC, &H80C9, &HD8, &H80DD, &H80D7, 210, 240, &H80F5, &H80FF, 250, &H80EB, &HEE, &HE4, &H80E1, 160, &H80A5, &H80AF, 170, &H80BB, 190, 180, &H80B1, &H8093, 150, &H9C, &H8099, &H88, &H808D, &H8087, 130, &H8183, 390, &H18C, &H8189, &H198, &H819D, &H8197, &H192, &H1B0, &H81B5, &H81BF, &H1BA, &H81AB, 430, 420, &H81A1, 480, &H81E5, &H81EF, 490, &H81FB, 510, 500, &H81F1, &H81D3, 470, &H1DC, &H81D9, &H1C8, &H81CD, &H81C7, 450, 320, &H8145, &H814F, 330, &H815B, 350, 340, &H8151, &H8173, &H176, 380, &H8179, 360, &H816D, &H8167, &H162, &H8123, &H126, 300, &H8129, &H138, &H813D, &H8137, &H132, &H110, &H8115, &H811F, &H11A, &H810B, 270, 260, &H8101, &H8303, &H306, 780, &H8309, &H318, &H831D, &H8317, &H312, &H330, &H8335, &H833F, &H33A, &H832B, &H32E, &H324, &H8321, &H360, &H8365, &H836F, &H36A, &H837B, &H37E, &H374, &H8371, &H8353, &H356, 860, &H8359, 840, &H834D, &H8347, &H342, 960, &H83C5, &H83CF, 970, &H83DB, 990, 980, &H83D1, &H83F3, &H3F6, &H3FC, &H83F9, &H3E8, &H83ED, &H83E7, &H3E2, &H83A3, &H3A6, 940, &H83A9, &H3B8, &H83BD, &H83B7, &H3B2, &H390, &H8395, &H839F, &H39A, &H838B, 910, 900, &H8381, 640, &H8285, &H828F, 650, &H829B, 670, 660, &H8291, &H82B3, &H2B6, 700, &H82B9, 680, &H82AD, &H82A7, &H2A2, &H82E3, &H2E6, &H2EC, &H82E9, 760, &H82FD, &H82F7, &H2F2, 720, &H82D5, &H82DF, 730, &H82CB, &H2CE, &H2C4, &H82C1, &H8243, &H246, &H24C, &H8249, 600, &H825D, &H8257, &H252, &H270, &H8275, &H827F, &H27A, &H826B, &H26E, &H264, &H8261, &H220, &H8225, &H822F, &H22A, &H823B, &H23E, &H234, &H8231, &H8213, &H216, 540, &H8219, 520, &H820D, &H8207, &H202}
            Dim num As Short = 0
            Dim x As Integer
            For x = 0 To Count - 1
                num = CShort(((num << 8) Xor CRC16_TABLE(((num >> 8) Xor TheBytes(x + Offset)))))
            Next x
            Return num
        End Function
#End Region


    End Module
End Namespace