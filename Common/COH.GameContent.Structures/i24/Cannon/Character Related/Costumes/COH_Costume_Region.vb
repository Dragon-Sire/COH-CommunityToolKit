﻿Imports COH.GameContent.Structures.Costumes.Mesh

Namespace Costumes
    Public NotInheritable Class COH_CostumeRegion
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property Keys As String()
            Get
                Return mKeys
            End Get
            Set(value As String())
                mKeys = value
            End Set
        End Property
        Property BoneSet As COH_CostumeBone()
            Get
                Return mBoneSet
            End Get
            Set(value As COH_CostumeBone())
                mBoneSet = value
            End Set
        End Property
        Property StoreCategory As String
            Get
                Return mStoreCategory
            End Get
            Set(value As String)
                mStoreCategory = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFilename As String
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mKeys As String()
       Private mBoneSet As COH_CostumeBone()
       Private mStoreCategory As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mFilename = String.Empty
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mKeys = New String() {}
            mBoneSet = New COH_CostumeBone() {}
            mStoreCategory = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            For Each TheBone In mBoneSet
                TheBone.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeRegion
            Dim Result As COH_CostumeRegion = New COH_CostumeRegion
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFilename = String.Copy(mFilename)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mKeys = mKeys.CloneTheStrings
                .mBoneSet = New COH_CostumeBone(mBoneSet.Count - 1) {}
                For X = 0 To mBoneSet.Count - 1
                    .mBoneSet(X) = mBoneSet(X).Clone
                Next
                .mStoreCategory = String.Copy(mStoreCategory)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_StringArray(mKeys)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mKey)
            If CurrentWriter.Write_CrypticS_StructArray(mBoneSet) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mStoreCategory)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mKeys = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mKey = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeBone), mBoneSet) = False Then Return False
            mStoreCategory = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
