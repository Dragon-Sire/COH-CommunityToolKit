Namespace CodeManagement.Enums.Binary
    Public Enum COH_Supported_BinaryByteOrder
        LittleEndian = 0
        BigEndian = 1
        [Default] = 254
        ShowAll = 255
    End Enum
    Public Enum COH_Supported_StringEncoding
        [Default] = 0
        UTF7 = 1
        UTF8 = 2
        UTF16 = 3
        UTF16_BigEndian = 4
        UTF32 = 5
        ASCII = 6
        UTF16_Fixed2Bytes = 7
    End Enum
    Public Enum COH_Supported_StringLengthMarker
        ZeroTerminated = 0
        LengthMarker = 1
        LengthMarker_NumberCharacters = 3
        NoIndicators = 2 '//THIS OS NOT A GREAT IDEA
        ShowAll = 255
    End Enum
    Public Enum COH_TriBoolean As Byte
        [True] = 0
        [False] = 1
        Unknown = 2
    End Enum
    <Flags> Public Enum COH_CleanStringFlags
        None = 0
        Trim = 1
        Remove_NonVisibleCharacters = 2
        Remove_Spaces = 4
        Remove_DoubleSpaces = 8
        Remove_NewLines = 16
        Remove_SingleSpacedLines = 32
        Remove_DoubleSpacedLines = 64
        AllowNull = 128
        ReturnOnZero = 256
    End Enum
End Namespace