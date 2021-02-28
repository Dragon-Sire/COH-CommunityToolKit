Namespace GameContent.Structures.[Shared]
    Public Class COH_AttributeNameTable
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Attribute Names"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Damage As COH_AttributeName()
            Get
                Return mDamage
            End Get
            Set(value As COH_AttributeName())
                mDamage = value
            End Set
        End Property
        Property Defense As COH_AttributeName()
            Get
                Return mDefense
            End Get
            Set(value As COH_AttributeName())
                mDefense = value
            End Set
        End Property
        Property Boost As COH_AttributeName()
            Get
                Return mBoost
            End Get
            Set(value As COH_AttributeName())
                mBoost = value
            End Set
        End Property
        Property Group As COH_AttributeName()
            Get
                Return mGroup
            End Get
            Set(value As COH_AttributeName())
                mGroup = value
            End Set
        End Property
        Property Mode As COH_AttributeName()
            Get
                Return mMode
            End Get
            Set(value As COH_AttributeName())
                mMode = value
            End Set
        End Property
        Property Elusivity As COH_AttributeName()
            Get
                Return mElusivity
            End Get
            Set(value As COH_AttributeName())
                mElusivity = value
            End Set
        End Property
        Property StackKey As COH_AttributeName()
            Get
                Return mStackKey
            End Get
            Set(value As COH_AttributeName())
                mStackKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mDamage As COH_AttributeName()
       Private mDefense As COH_AttributeName()
       Private mBoost As COH_AttributeName()
       Private mGroup As COH_AttributeName()
       Private mMode As COH_AttributeName()
       Private mElusivity As COH_AttributeName()
       Private mStackKey As COH_AttributeName()
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            '//mName = "Attributes Names"
            mDamage = New COH_AttributeName() {}
            mDefense = New COH_AttributeName() {}
            mBoost = New COH_AttributeName() {}
            mGroup = New COH_AttributeName() {}
            mMode = New COH_AttributeName() {}
            mElusivity = New COH_AttributeName() {}
            mStackKey = New COH_AttributeName() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            For Each Item In mDamage
                Item.UpdateLocalizations(LocalizeController)
            Next
            For Each Item In mDefense
                Item.UpdateLocalizations(LocalizeController)
            Next
            For Each Item In mBoost
                Item.UpdateLocalizations(LocalizeController)
            Next
            For Each Item In mGroup
                Item.UpdateLocalizations(LocalizeController)
            Next
            For Each Item In mMode
                Item.UpdateLocalizations(LocalizeController)
            Next
            For Each Item In mElusivity
                Item.UpdateLocalizations(LocalizeController)
            Next
            For Each Item In mStackKey
                Item.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Special - Convert to List of Enums"
        Sub Convert_ToEnumList()
            Dim EnumSource As COH_Enum_Attrib_CharacterAll = 0
            Dim EnumStrings As String() = [Enum].GetNames(GetType(COH_Enum_Attrib_CharacterAll))

            Dim Result As New List(Of String)
            'Result.AddRange(Convert_ToEnumList_MacthAttributeNames("kDamageType{0:D2}", EnumStrings, mDamage))
            'Result.AddRange(Convert_ToEnumList_MacthAttributeNames("kElusivity{0:D2}", EnumStrings, mElusivity))
            'Result.AddRange(Convert_ToEnumList_MacthAttributeNames("kDefenseType{0:D2}", EnumStrings, mDefense))
            '//ORIGINS
            Result.AddRange(Convert_ToEnumList_AttributeNamesOrigin("{0:D2}", EnumStrings, mBoost))
            '//No Search
            Result.AddRange(Convert_ToEnumList_AttributeNames("{0:D2}", EnumStrings, mMode))
            Result.AddRange(Convert_ToEnumList_AttributeNames("{0:D2}", EnumStrings, mGroup))
            Result.AddRange(Convert_ToEnumList_AttributeNames("{0:D2}", EnumStrings, mStackKey))
            Dim TEMP As String = String.Join(ChrW(10), Result)
        End Sub
        Private Function Convert_ToEnumList_MacthAttributeNames(FormatString As String, ByRef EnumStrings As String(), ByRef TheList As COH_AttributeName()) As List(Of String)
            'Dim EnumSource As COH_Enum_Attrib
            Dim ResultList As New List(Of String)
            Dim Index As Integer = 0
            Dim NewItem As String = ""
            For X = 0 To TheList.Count - 1
                Dim Find = String.Format(FormatString, X)
                Dim Padding As String = ""
                Dim MaxLength As Integer = 80
                Do
                    Dim CompareToString As String = EnumStrings(Index)
                    If CompareToString = Find Then
                        Dim FirstPart As String = "<COH_DescriptionEnum(""" & TheList(X).Name.Replace("_", " ") & """)>k" & TheList(X).Name & " = " & (Index * 4).ToString
                        NewItem = FirstPart & New String(" ", MaxLength - FirstPart.Length) & ChrW(9) & "'" & Find
                        ResultList.Add(NewItem)
                        Exit Do
                    End If
                    Index += 1
                Loop
            Next
            Return ResultList
        End Function
        Private Function Convert_ToEnumList_AttributeNames(FormatString As String, ByRef EnumStrings As String(), ByRef TheList As COH_AttributeName()) As List(Of String)
            'Dim EnumSource As COH_Enum_Attrib
            Dim ResultList As New List(Of String)
            Dim Index As Integer = 0
            Dim NewItem As String = ""
            For X = 0 To TheList.Count - 1
                NewItem = "<COH_DescriptionEnum(""" & TheList(X).Name.Replace("_", " ") & """)>k" & TheList(X).Name & " = " & String.Format(FormatString, X)
                ResultList.Add(NewItem)
            Next
            Return ResultList
        End Function
        Private Function Convert_ToEnumList_AttributeNamesOrigin(FormatString As String, ByRef EnumStrings As String(), ByRef TheList As COH_AttributeName()) As List(Of String)
            Dim EnumStrings2 As String() = [Enum].GetNames(GetType(COH_Enum_Attrib_OriginBoosts))
            Dim ResultList As New List(Of String)
            Dim Index As Integer = 0
            Dim NewItem As String = ""
            For X = 0 To TheList.Count - 1
                NewItem = "<COH_DescriptionEnum(""" & TheList(X).Name.Replace("_", " ") & """)>k" & TheList(X).Name & " = " & String.Format(FormatString, X + EnumStrings2.Count)
                ResultList.Add(NewItem)
            Next
            Return ResultList
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_AttributeNameTable
            Dim Result As COH_AttributeNameTable = New COH_AttributeNameTable
            With Result
                .mDamage = New COH_AttributeName(mDamage.Count - 1) {}
                For X = 0 To mDamage.Count - 1
                    .mDamage(X) = mDamage(X).Clone
                Next
                .mDefense = New COH_AttributeName(mDefense.Count - 1) {}
                For X = 0 To mDefense.Count - 1
                    .mDefense(X) = mDefense(X).Clone
                Next
                .mBoost = New COH_AttributeName(mBoost.Count - 1) {}
                For X = 0 To mBoost.Count - 1
                    .mBoost(X) = mBoost(X).Clone
                Next
                .mGroup = New COH_AttributeName(mGroup.Count - 1) {}
                For X = 0 To mGroup.Count - 1
                    .mGroup(X) = mGroup(X).Clone
                Next
                .mMode = New COH_AttributeName(mMode.Count - 1) {}
                For X = 0 To mMode.Count - 1
                    .mMode(X) = mMode(X).Clone
                Next
                .mElusivity = New COH_AttributeName(mElusivity.Count - 1) {}
                For X = 0 To mElusivity.Count - 1
                    .mElusivity(X) = mElusivity(X).Clone
                Next
                .mStackKey = New COH_AttributeName(mStackKey.Count - 1) {}
                For X = 0 To mStackKey.Count - 1
                    .mStackKey(X) = mStackKey(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeName), Damage) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeName), Defense) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeName), Boost) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeName), Group) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeName), Mode) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeName), Elusivity) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeName), StackKey) = False Then Return False
            Return True
        End Function
#End Region


    End Class
End Namespace