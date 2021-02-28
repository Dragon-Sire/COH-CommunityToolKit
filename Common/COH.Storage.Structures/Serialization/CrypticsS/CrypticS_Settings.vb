Namespace Storage.Structures.CrypticsS
    Public NotInheritable Class COH_CrypticS_Settings

#Region "Enums"
        Public Enum COH_CombineStructs_Option
            SeperateFiles = 0
            AllCombined = 1
            '// Combine_WhereAppropriate = 2
        End Enum
#End Region

#Region "Property Options"
        Public Property Option_BINs_UpdateTimeStamps As Boolean
            Get
                Return mUpdate_Bin_TimeStamps
            End Get
            Set(value As Boolean)
                mUpdate_Bin_TimeStamps = value
            End Set
        End Property
        Public Property Option_BINs_CombineStructures As COH_CombineStructs_Option
            Get
                Return mCombineStructures
            End Get
            Set(value As COH_CombineStructs_Option)
                mCombineStructures = value
            End Set
        End Property
        Public Property Option_Export_DontWriteEmpty As Boolean
            Get
                Return mExportOption_DontWriteEmpty
            End Get
            Set(value As Boolean)
                mExportOption_DontWriteEmpty = value
            End Set
        End Property
        Public Property Option_ExportDontWriteDefaults As Boolean
            Get
                Return mExportOption_DontWriteDefaults
            End Get
            Set(value As Boolean)
                mExportOption_DontWriteDefaults = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mUpdate_Bin_TimeStamps As Boolean
        Private mCombineStructures As COH_CombineStructs_Option
        Private mExportOption_DontWriteDefaults As Boolean = False
        Private mExportOption_DontWriteEmpty As Boolean = False
#End Region

#Region "Create New Instance"
        Public Sub New()
            mUpdate_Bin_TimeStamps = False
            mCombineStructures = COH_CombineStructs_Option.SeperateFiles
        End Sub
        Public Sub New(UpdateTimeStamp As Boolean, CombineStructures As COH_CombineStructs_Option)
            mUpdate_Bin_TimeStamps = False
            mCombineStructures = CombineStructures
        End Sub
#End Region
    End Class

End Namespace
